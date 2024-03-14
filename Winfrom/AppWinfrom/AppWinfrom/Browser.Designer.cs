namespace AppWinfrom
{
    partial class BrowserWindow
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
            System.Windows.Forms.WebBrowser webBrowser1;
            this.btnCancel = new System.Windows.Forms.Button();
            webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            webBrowser1.Location = new System.Drawing.Point(2, 74);
            webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new System.Drawing.Size(1163, 640);
            webBrowser1.TabIndex = 2;
            webBrowser1.Url = new System.Uri("https://www7.53kf.com/webCompany.php?arg=10435131&kf_sign=TY0MjMTcwOY1ODEyMjU4MTg" +
        "0MDIyMDAxNzI0MzUxMzE%253D&style=1", System.UriKind.Absolute);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(1031, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 55);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 715);
            this.Controls.Add(webBrowser1);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BrowserWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowserHelper";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
    }
}