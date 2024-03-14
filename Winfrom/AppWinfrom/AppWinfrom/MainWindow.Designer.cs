namespace AppWinfrom
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMyOrder = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxSelectVersion = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnNowInstall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMyOrder);
            this.panel1.Controls.Add(this.btnService);
            this.panel1.Location = new System.Drawing.Point(871, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 91);
            this.panel1.TabIndex = 0;
            // 
            // btnMyOrder
            // 
            this.btnMyOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMyOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyOrder.Location = new System.Drawing.Point(147, 18);
            this.btnMyOrder.Name = "btnMyOrder";
            this.btnMyOrder.Size = new System.Drawing.Size(116, 61);
            this.btnMyOrder.TabIndex = 1;
            this.btnMyOrder.Text = "我的订单";
            this.btnMyOrder.UseVisualStyleBackColor = false;
            this.btnMyOrder.Click += new System.EventHandler(this.btnMyOrder_Click);
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnService.Location = new System.Drawing.Point(14, 18);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(116, 61);
            this.btnService.TabIndex = 0;
            this.btnService.Text = "在线客服";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(47, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择版本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(46, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "手机号码：";
            // 
            // comboxSelectVersion
            // 
            this.comboxSelectVersion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxSelectVersion.FormattingEnabled = true;
            this.comboxSelectVersion.Location = new System.Drawing.Point(160, 507);
            this.comboxSelectVersion.Name = "comboxSelectVersion";
            this.comboxSelectVersion.Size = new System.Drawing.Size(295, 28);
            this.comboxSelectVersion.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(160, 561);
            this.textBoxPhoneNumber.MaxLength = 11;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(295, 36);
            this.textBoxPhoneNumber.TabIndex = 4;
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNumber_KeyPress);
            // 
            // btnNowInstall
            // 
            this.btnNowInstall.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNowInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNowInstall.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNowInstall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNowInstall.Location = new System.Drawing.Point(499, 501);
            this.btnNowInstall.Name = "btnNowInstall";
            this.btnNowInstall.Size = new System.Drawing.Size(223, 107);
            this.btnNowInstall.TabIndex = 5;
            this.btnNowInstall.Text = "立即安装";
            this.btnNowInstall.UseVisualStyleBackColor = false;
            this.btnNowInstall.Click += new System.EventHandler(this.btnNowInstall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "请输入手机号";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppWinfrom.Properties.Resources.Left;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 715);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNowInstall);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.comboxSelectVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCAD安装助手";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMyOrder;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxSelectVersion;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button btnNowInstall;
        private System.Windows.Forms.Label label3;
    }
}

