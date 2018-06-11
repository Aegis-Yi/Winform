namespace Login
{
    partial class Form2
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
            this.TxtUsrePassword = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.Label();
            this.ButColse = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ReLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "密码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // TxtUsrePassword
            // 
            this.TxtUsrePassword.AutoSize = true;
            this.TxtUsrePassword.Location = new System.Drawing.Point(400, 183);
            this.TxtUsrePassword.Name = "TxtUsrePassword";
            this.TxtUsrePassword.Size = new System.Drawing.Size(0, 24);
            this.TxtUsrePassword.TabIndex = 2;
            // 
            // TxtUserName
            // 
            this.TxtUserName.AutoSize = true;
            this.TxtUserName.Location = new System.Drawing.Point(400, 114);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(0, 24);
            this.TxtUserName.TabIndex = 3;
            // 
            // ButColse
            // 
            this.ButColse.Location = new System.Drawing.Point(332, 303);
            this.ButColse.Name = "ButColse";
            this.ButColse.Size = new System.Drawing.Size(124, 62);
            this.ButColse.TabIndex = 4;
            this.ButColse.Text = "确认";
            this.ButColse.UseVisualStyleBackColor = true;
            this.ButColse.Click += new System.EventHandler(this.ButColse_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReLoginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 39);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ReLoginToolStripMenuItem
            // 
            this.ReLoginToolStripMenuItem.Name = "ReLoginToolStripMenuItem";
            this.ReLoginToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.ReLoginToolStripMenuItem.Text = "重新登陆";
            this.ReLoginToolStripMenuItem.Click += new System.EventHandler(this.ReLoginToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 702);
            this.Controls.Add(this.ButColse);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtUsrePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtUsrePassword;
        private System.Windows.Forms.Label TxtUserName;
        private System.Windows.Forms.Button ButColse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ReLoginToolStripMenuItem;
    }
}