using AppWinfrom.Model;
using AppWinfrom.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppWinfrom
{
    public partial class PayOverWindow : Form
    {
        private string BIOSNum;
        private PayOver payover;
        private int selectversion;
        private DataModel model;
        private string type;

        private PayOverWindow()
        {
            InitializeComponent();
        }
        public PayOverWindow(string type,int selectversion, string BIOSNum) : this()
        {
            this.BIOSNum = BIOSNum;
            this.selectversion = selectversion;
            this.type = type;
        }

        private void PayOverWindow_Load(object sender, EventArgs e)
        {
            Image img = null;
            var model = HttpHelper.GetDataModel();
            img = Base64ImgHelper.Base64StrToImg(model.data.kefu);
            //显示客服二维码
            this.PictureBoxKefu.Image = img;
            //查询订单状态获取下载地址以及教程地址
            payover = HttpHelper.PayOver(BIOSNum);
        }
        private void PayOverExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            var xzdz = "";
            //比对已经购买的产品名是否有已经选择的产品
            for (int i = 0; i <= payover.data.Length; i++)
            {
                var checktype = payover.data[i].O_gg;
                if (type == checktype)
                {
                    xzdz = payover.data[i].O_xz;
                    break;
                }

            }
            xzdz = xzdz.Replace("下载地址：", "");
            Process.Start(xzdz);

        }
        private void button2_Click(object sender, EventArgs e)
    {
            DataModel model = HttpHelper.GetDataModel();
            var domain=model.data.domain.ToString();
            var fahuo = "";
            //比对已经购买的产品名是否有已经选择的产品
            for (int i = 0; i <= payover.data.Length; i++)
            {
                var checktype = payover.data[i].O_gg;
                if (type== checktype) {
                    fahuo = payover.data[i].fahuo;
                    break;
                }
           
            }
            fahuo = fahuo.Replace("http:///member/", "http://" + domain + "/member/");
            Process.Start(fahuo);
        }
    }
}
