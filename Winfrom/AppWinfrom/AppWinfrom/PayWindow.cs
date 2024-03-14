using AppWinfrom.Model;
using AppWinfrom.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AppWinfrom
{
    public partial class PayWindow : Form
    {
        private string type;
        private string telNumber;
        private Purchase Purchase;

        public string BIOSNum;

        public PayWindow(string type, Purchase Purchase, string BIOSNum)
        {
            InitializeComponent();
            this.type = type;
            this.Purchase = Purchase;
            this.BIOSNum = BIOSNum;
            InitInfo();
            ThreadPool.QueueUserWorkItem(_ =>
            {
                LookQuery();
            });
        }

        //public PayWindow(string type, string telNumber, string code)
        //{
        //    InitializeComponent();
        //    this.type = type;
        //    this.telNumber = telNumber;
        //    this.code = code;
        //    InitInfo();
        //}

        private void InitInfo()
        {
            SoftVersionDisplay.Text = this.type;
            //1 根据type 请求接口，获取价格
            MoneyDisplay.Text = $"￥{Purchase.money}元/永久激活 当前订单号:-->{Purchase.order_id}";
            QueryPayQR(isFirst: true);
        }

        private void QueryPayQR(string type = "weixin", bool isFirst = false)
        {
            if (this.PayQR.Image != null)
            {
                this.PayQR.Image.Dispose();
            }
            Image img = null;
            //判断是不是第一次请求
            if (isFirst)
            {
                img = Base64ImgHelper.Base64StrToImg(Purchase.ewm);
            }
            else
            {
                var model = HttpHelper.GetQR(Purchase.order_id, type);
                img = Base64ImgHelper.Base64StrToImg(model.ewm);
            }
            this.PayQR.Image = img;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void changePayQR_CLick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var type = button.Tag.ToString();
            QueryPayQR(type, false);
        }


        bool isRun = true;
        private void LookQuery()
        {
            while (isRun)
            {
                var state = HttpHelper.PayStatus(Purchase.order_id, BIOSNum);
                if (state.status == 1)
                {
                    isRun = false;
                    StateChangeAndClose();
                    return;
                }
                Thread.Sleep(2000);
            }
        }

        private void StateChangeAndClose()
        {
            this.ThreadSafeCall(() =>
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            });
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            isRun = false;
            base.OnClosing(e);
        }

    }
}
