namespace WindowsFormsAppCalc
{
    partial class FrmCalc
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            txtNum = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数量为整数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数量可以为小数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(258, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "数量";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNum
            // 
            txtNum.Location = new System.Drawing.Point(470, 178);
            txtNum.Margin = new System.Windows.Forms.Padding(6);
            txtNum.Name = "txtNum";
            txtNum.Size = new System.Drawing.Size(196, 35);
            txtNum.TabIndex = 2;
            txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            txtNum.Enter += new System.EventHandler(this.txtMoney_enter);
            txtNum.Leave += new System.EventHandler(this.txtNum_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(470, 262);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(196, 35);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.Enter += new System.EventHandler(this.txtMoney_enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtNum_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(258, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "单价";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(470, 350);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(6);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(196, 35);
            this.txtMoney.TabIndex = 6;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            this.txtMoney.Enter += new System.EventHandler(this.txtMoney_enter);
            this.txtMoney.Leave += new System.EventHandler(this.txtMoney_Leave);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(258, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "金额";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置CToolStripMenuItem,
            this.编辑EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 39);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置CToolStripMenuItem
            // 
            this.设置CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数量为整数ToolStripMenuItem,
            this.数量可以为小数ToolStripMenuItem});
            this.设置CToolStripMenuItem.Name = "设置CToolStripMenuItem";
            this.设置CToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            this.设置CToolStripMenuItem.Text = "设置(&C)";
            // 
            // 数量为整数ToolStripMenuItem
            // 
            this.数量为整数ToolStripMenuItem.Name = "数量为整数ToolStripMenuItem";
            this.数量为整数ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.数量为整数ToolStripMenuItem.Text = "数量为整数";
            this.数量为整数ToolStripMenuItem.Click += new System.EventHandler(this.txtIntToolStripMenuItem_Click);
            // 
            // 数量可以为小数ToolStripMenuItem
            // 
            this.数量可以为小数ToolStripMenuItem.Name = "数量可以为小数ToolStripMenuItem";
            this.数量可以为小数ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.数量可以为小数ToolStripMenuItem.Text = "数量可以为小数";
            this.数量可以为小数ToolStripMenuItem.Click += new System.EventHandler(this.txtDouToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.txtPastToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.txtCopyToolStripMenuItem_Click);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 680);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCalc";
            this.Text = "数量单价金额的计算";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        static private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数量为整数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数量可以为小数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
    }
}

