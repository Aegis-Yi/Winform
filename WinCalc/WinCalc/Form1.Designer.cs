namespace WinCalc
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
            this.lblDisp = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.程序员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.统计信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisp
            // 
            this.lblDisp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisp.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDisp.Location = new System.Drawing.Point(1, 0);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(235, 23);
            this.lblDisp.TabIndex = 0;
            this.lblDisp.Text = "123456  *";
            this.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(24, 22);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(212, 21);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "1234.56";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMem
            // 
            this.lblMem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMem.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMem.Location = new System.Drawing.Point(0, 23);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(27, 21);
            this.lblMem.TabIndex = 2;
            this.lblMem.Text = "M";
            this.lblMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDisp);
            this.panel1.Controls.Add(this.lblMem);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Location = new System.Drawing.Point(17, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 47);
            this.panel1.TabIndex = 3;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看VToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(272, 25);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // 查看VToolStripMenuItem
            // 
            this.查看VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.标准ToolStripMenuItem,
            this.科学ToolStripMenuItem,
            this.程序员ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.统计信息ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.关闭ToolStripMenuItem});
            this.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem";
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.查看VToolStripMenuItem.Text = "查看(&V)";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 标准ToolStripMenuItem
            // 
            this.标准ToolStripMenuItem.Name = "标准ToolStripMenuItem";
            this.标准ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.标准ToolStripMenuItem.Text = "标准";
            // 
            // 科学ToolStripMenuItem
            // 
            this.科学ToolStripMenuItem.Name = "科学ToolStripMenuItem";
            this.科学ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.科学ToolStripMenuItem.Text = "科学";
            // 
            // 程序员ToolStripMenuItem
            // 
            this.程序员ToolStripMenuItem.Name = "程序员ToolStripMenuItem";
            this.程序员ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.程序员ToolStripMenuItem.Text = "程序员";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // 统计信息ToolStripMenuItem
            // 
            this.统计信息ToolStripMenuItem.Name = "统计信息ToolStripMenuItem";
            this.统计信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.统计信息ToolStripMenuItem.Text = "统计信息";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(37, 322);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(109, 31);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(157, 322);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(49, 31);
            this.btnPoint.TabIndex = 6;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(97, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(97, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 31);
            this.button6.TabIndex = 12;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(157, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 31);
            this.button7.TabIndex = 11;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(37, 234);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 31);
            this.button8.TabIndex = 10;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(97, 190);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 31);
            this.button9.TabIndex = 15;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(157, 190);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 31);
            this.button10.TabIndex = 14;
            this.button10.Tag = "";
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(37, 190);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 31);
            this.button11.TabIndex = 13;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(37, 144);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(49, 31);
            this.btnBackSpace.TabIndex = 16;
            this.btnBackSpace.Text = "<—";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 378);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FrmCalc";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.FrmCalc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCalc_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCalc_KeyPress);
            this.panel1.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem 查看VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标准ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科学ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 程序员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 统计信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnBackSpace;
    }
}

