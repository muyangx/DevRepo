namespace AppWinfrom
{
    partial class PayWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SoftVersionDisplay = new System.Windows.Forms.Label();
            this.VersionTextDisplay = new System.Windows.Forms.Label();
            this.MoneyDisplay = new System.Windows.Forms.Label();
            this.BtnAlipay = new System.Windows.Forms.Button();
            this.BtnWexin = new System.Windows.Forms.Button();
            this.PayQR = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PayQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单详情";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "软件版本：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "版本说明：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "应付金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "扫码支付：";
            // 
            // SoftVersionDisplay
            // 
            this.SoftVersionDisplay.AutoSize = true;
            this.SoftVersionDisplay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftVersionDisplay.Location = new System.Drawing.Point(120, 63);
            this.SoftVersionDisplay.Name = "SoftVersionDisplay";
            this.SoftVersionDisplay.Size = new System.Drawing.Size(79, 20);
            this.SoftVersionDisplay.TabIndex = 5;
            this.SoftVersionDisplay.Text = "CAD2021";
            // 
            // VersionTextDisplay
            // 
            this.VersionTextDisplay.AutoSize = true;
            this.VersionTextDisplay.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VersionTextDisplay.Location = new System.Drawing.Point(111, 113);
            this.VersionTextDisplay.Name = "VersionTextDisplay";
            this.VersionTextDisplay.Size = new System.Drawing.Size(370, 24);
            this.VersionTextDisplay.TabIndex = 6;
            this.VersionTextDisplay.Text = "一次付费，永久使用，安装不成功，全额退款";
            // 
            // MoneyDisplay
            // 
            this.MoneyDisplay.AutoSize = true;
            this.MoneyDisplay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MoneyDisplay.ForeColor = System.Drawing.Color.Red;
            this.MoneyDisplay.Location = new System.Drawing.Point(114, 163);
            this.MoneyDisplay.Name = "MoneyDisplay";
            this.MoneyDisplay.Size = new System.Drawing.Size(189, 20);
            this.MoneyDisplay.TabIndex = 7;
            this.MoneyDisplay.Text = "￥49.80元/永久激活";
            // 
            // BtnAlipay
            // 
            this.BtnAlipay.BackColor = System.Drawing.Color.Transparent;
            this.BtnAlipay.BackgroundImage = global::AppWinfrom.Properties.Resources.AlipayButton;
            this.BtnAlipay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlipay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAlipay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAlipay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlipay.Location = new System.Drawing.Point(362, 311);
            this.BtnAlipay.Name = "BtnAlipay";
            this.BtnAlipay.Size = new System.Drawing.Size(140, 57);
            this.BtnAlipay.TabIndex = 10;
            this.BtnAlipay.Tag = "alipay";
            this.BtnAlipay.UseVisualStyleBackColor = false;
            this.BtnAlipay.Click += new System.EventHandler(this.changePayQR_CLick);
            // 
            // BtnWexin
            // 
            this.BtnWexin.BackColor = System.Drawing.Color.Transparent;
            this.BtnWexin.BackgroundImage = global::AppWinfrom.Properties.Resources.WeChatButton;
            this.BtnWexin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnWexin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnWexin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnWexin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWexin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnWexin.Location = new System.Drawing.Point(362, 237);
            this.BtnWexin.Name = "BtnWexin";
            this.BtnWexin.Size = new System.Drawing.Size(140, 57);
            this.BtnWexin.TabIndex = 9;
            this.BtnWexin.Tag = "weixin";
            this.BtnWexin.UseVisualStyleBackColor = false;
            this.BtnWexin.Click += new System.EventHandler(this.changePayQR_CLick);
            // 
            // PayQR
            // 
            this.PayQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PayQR.Location = new System.Drawing.Point(104, 228);
            this.PayQR.Name = "PayQR";
            this.PayQR.Size = new System.Drawing.Size(252, 259);
            this.PayQR.TabIndex = 8;
            this.PayQR.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(362, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 57);
            this.button3.TabIndex = 11;
            this.button3.Text = "返回重选";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(557, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnAlipay);
            this.Controls.Add(this.BtnWexin);
            this.Controls.Add(this.PayQR);
            this.Controls.Add(this.MoneyDisplay);
            this.Controls.Add(this.VersionTextDisplay);
            this.Controls.Add(this.SoftVersionDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PayWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PayQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SoftVersionDisplay;
        private System.Windows.Forms.Label VersionTextDisplay;
        private System.Windows.Forms.Label MoneyDisplay;
        private System.Windows.Forms.PictureBox PayQR;
        private System.Windows.Forms.Button BtnWexin;
        private System.Windows.Forms.Button BtnAlipay;
        private System.Windows.Forms.Button button3;
    }
}