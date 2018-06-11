namespace Login
{
    partial class Form1
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
            this.TxtName = new System.Windows.Forms.ComboBox();
            this.ButOK = new System.Windows.Forms.Button();
            this.ButExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.FormattingEnabled = true;
            this.TxtName.Location = new System.Drawing.Point(287, 100);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(258, 32);
            this.TxtName.TabIndex = 0;
            // 
            // ButOK
            // 
            this.ButOK.Location = new System.Drawing.Point(287, 296);
            this.ButOK.Name = "ButOK";
            this.ButOK.Size = new System.Drawing.Size(105, 54);
            this.ButOK.TabIndex = 1;
            this.ButOK.Text = "登陆";
            this.ButOK.UseVisualStyleBackColor = true;
            this.ButOK.Click += new System.EventHandler(this.ButOK_Click);
            // 
            // ButExit
            // 
            this.ButExit.Location = new System.Drawing.Point(440, 296);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(105, 54);
            this.ButExit.TabIndex = 2;
            this.ButExit.Text = "退出";
            this.ButExit.UseVisualStyleBackColor = true;
            this.ButExit.Click += new System.EventHandler(this.ButExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(287, 160);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(258, 35);
            this.TxtPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButExit);
            this.Controls.Add(this.ButOK);
            this.Controls.Add(this.TxtName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TxtName;
        private System.Windows.Forms.Button ButOK;
        private System.Windows.Forms.Button ButExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
    }
}

