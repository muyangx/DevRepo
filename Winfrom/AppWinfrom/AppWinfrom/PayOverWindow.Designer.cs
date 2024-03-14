namespace AppWinfrom
{
    partial class PayOverWindow
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
            this.BtnDownload = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PictureBoxKefu = new System.Windows.Forms.PictureBox();
            this.PayOverExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKefu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "下载地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "安装教程：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(37, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "安装说明：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(37, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "售后客服：";
            // 
            // BtnDownload
            // 
            this.BtnDownload.BackColor = System.Drawing.Color.Orange;
            this.BtnDownload.FlatAppearance.BorderSize = 0;
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownload.Location = new System.Drawing.Point(182, 40);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(108, 53);
            this.BtnDownload.TabIndex = 4;
            this.BtnDownload.Text = "点击下载";
            this.BtnDownload.UseVisualStyleBackColor = false;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(182, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "点击下载";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PictureBoxKefu
            // 
            this.PictureBoxKefu.Location = new System.Drawing.Point(141, 405);
            this.PictureBoxKefu.Name = "PictureBoxKefu";
            this.PictureBoxKefu.Size = new System.Drawing.Size(257, 262);
            this.PictureBoxKefu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxKefu.TabIndex = 6;
            this.PictureBoxKefu.TabStop = false;
            // 
            // PayOverExit
            // 
            this.PayOverExit.BackColor = System.Drawing.Color.Transparent;
            this.PayOverExit.FlatAppearance.BorderSize = 0;
            this.PayOverExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayOverExit.Location = new System.Drawing.Point(585, 579);
            this.PayOverExit.Name = "PayOverExit";
            this.PayOverExit.Size = new System.Drawing.Size(63, 40);
            this.PayOverExit.TabIndex = 7;
            this.PayOverExit.Text = "关闭";
            this.PayOverExit.UseVisualStyleBackColor = false;
            this.PayOverExit.Click += new System.EventHandler(this.PayOverExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(152, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(454, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "安装遇到问题，请联系客服为你处理，\r\n处理时间：9:00-23:00";
            // 
            // PayOverWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(703, 679);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PayOverExit);
            this.Controls.Add(this.PictureBoxKefu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayOverWindow";
            this.Text = "PayOverWindow";
            this.Load += new System.EventHandler(this.PayOverWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKefu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox PictureBoxKefu;
        private System.Windows.Forms.Button PayOverExit;
        private System.Windows.Forms.Label label5;
    }
}