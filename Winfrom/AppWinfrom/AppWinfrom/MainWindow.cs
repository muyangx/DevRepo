using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using AppWinfrom.Utils;
using System.Collections;
using AppWinfrom.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static AppWinfrom.Model.PayOver;
using System.Diagnostics;

namespace AppWinfrom
{
    public partial class MainWindow : Form
    {
        private bool IsPayStatus=false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            var model = HttpHelper.GetDataModel();
            comboxSelectVersion.DisplayMember = "gg";
            comboxSelectVersion.ValueMember = "gg";
            comboxSelectVersion.DataSource = model.data.P_ggxqList;
            var BIOSNum = Utils.Utils.GetMotherboardSerialNumber(); //获取本机机器码
            //test
            //comboxSelectVersion.SelectedIndex = 1;
           // textBoxPhoneNumber.Text = "13544865214";

        }
        private void btnService_Click(object sender, EventArgs e)
        {
            //联系客服
            Process.Start("https://tb.53kf.com/code/client/6f58e7298d2d3fbf7285f41232b58c2b4/1");
        
        }

        private void btnNowInstall_Click(object sender, EventArgs e)
        {
            //获取本机机器码
            var BIOSNum = Utils.Utils.GetMotherboardSerialNumber();
            //BIOSNum = "test001";
            //查询订单是否存在过
            PayOver Payovermodel = HttpHelper.PayOver(BIOSNum);
            if (Payovermodel.code != 200)
            {
                IsPayStatus = false;
            }
            else
            {
                IsPayStatus = true;
                MessageBox.Show("系统检测到您已经购买过此产品，不需要再次付费");
                //ShowPayOverWindow(phone, BIOSNum);
            }

            //立即安装后的动作
            var type = comboxSelectVersion.Text;
            var phone = textBoxPhoneNumber.Text;
            //var BIOSNum = "19CA2EB8908695FA9ED6BC383E198C0E8D42939CC1472D2167151876E570D3A8";
            //var checkOrderStatus = HttpHelper.PayOver(BIOSNum).code;
            //BIOSNum = "test0001";
            // 判断
            if (string.IsNullOrEmpty(type) || comboxSelectVersion.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择一个有效的产品");
                return;
            }
            if (string.IsNullOrEmpty(phone) || !Utils.Utils.IsPhoneNumber(phone))
            {
                MessageBox.Show("请输入有效手机号");
                return;
            }
            //...
            //当前选择的第几个产品
            var selectversion = comboxSelectVersion.SelectedIndex+1;
            //把选择的产品传送给下单接口
            Purchase Purchase = HttpHelper.GetPurchase(selectversion,phone, BIOSNum);
            //如果库存不足弹窗提示
            if (Purchase.code == 400)
            {
                MessageBox.Show(Purchase.msg);
            }
            else {
                if (IsPayStatus == false)
                {
                    //通过机器码获取订单状态码判断是否弹出付款框
                    PayWindow pw = new PayWindow(type, Purchase, BIOSNum);
                    pw.Owner = this;
                    pw.StartPosition = FormStartPosition.Manual;
                    pw.Location = new Point(this.Location.X + 50, this.Location.Y + 100);
                    pw.ShowDialog();

                    if (pw.DialogResult == DialogResult.OK)
                    {

                        ShowPayOverWindow(type,selectversion, BIOSNum);
                    }
                }
                else
                {
                    ShowPayOverWindow(type,selectversion, BIOSNum);
                }
            }
         
        }

        private void ShowPayOverWindow(string type,int selectversion,string BIOSNum)
        {
            //下载页
            PayOverWindow pow = new PayOverWindow(type,selectversion, BIOSNum);
            pow.Owner = this;
            pow.StartPosition = FormStartPosition.Manual;
            pow.Location = new Point(this.Location.X + 50, this.Location.Y + 100);
            pow.ShowDialog();
        }


        private void FrmMain_FormClosed(object sender, FormClosingEventArgs e)
        {
            //完全关闭窗口
            Application.Exit();
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制手机号只能输入数字及小数点
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)

                e.Handled = true;

            //小数点的处理。

            if ((int)e.KeyChar == 46)                           //小数点

            {

                if (textBoxPhoneNumber.Text.Length <= 0)

                    e.Handled = true;   //小数点不能在第一位

                else

                {

                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBoxPhoneNumber.Text, out oldf);

                    b2 = float.TryParse(textBoxPhoneNumber.Text + e.KeyChar.ToString(), out f);

                    if (b2 == false)

                    {

                        if (b1 == true)

                            e.Handled = true;

                        else

                            e.Handled = false;

                    }

                }

            }
        }

        private void btnMyOrder_Click(object sender, EventArgs e)
        {
            Process.Start("https://zongz.xiaoai999.com/?type=text&id=6");
        }
    }
}
