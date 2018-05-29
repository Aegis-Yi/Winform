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
            this.components = new System.ComponentModel.Container();
            this.lblDisp = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.程序员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.统计信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPast = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txtAllClean = new System.Windows.Forms.Button();
            this.txtClrean = new System.Windows.Forms.Button();
            this.txtEqual = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.Button();
            this.txtDiv = new System.Windows.Forms.Button();
            this.txtMR = new System.Windows.Forms.Button();
            this.txtMadd = new System.Windows.Forms.Button();
            this.txtMsub = new System.Windows.Forms.Button();
            this.txtMclrean = new System.Windows.Forms.Button();
            this.txtCross = new System.Windows.Forms.Button();
            this.txtPOM = new System.Windows.Forms.Button();
            this.txtMod = new System.Windows.Forms.Button();
            this.txtRoot = new System.Windows.Forms.Button();
            this.txtSqrt = new System.Windows.Forms.Button();
            this.txtDao = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisp
            // 
            this.lblDisp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisp.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDisp.Location = new System.Drawing.Point(0, 0);
            this.lblDisp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(470, 46);
            this.lblDisp.TabIndex = 0;
            this.lblDisp.Text = "123456  *";
            this.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisp.Click += new System.EventHandler(this.lblDisp_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(48, 44);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(424, 42);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "1234.56";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblResult_MouseUp);
            // 
            // lblMem
            // 
            this.lblMem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMem.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMem.Location = new System.Drawing.Point(0, 46);
            this.lblMem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(54, 42);
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
            this.panel1.Location = new System.Drawing.Point(34, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 90);
            this.panel1.TabIndex = 3;
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看VToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.mainMenu.Size = new System.Drawing.Size(559, 43);
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
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(106, 35);
            this.查看VToolStripMenuItem.Text = "查看(&V)";
            // 
            // 标准ToolStripMenuItem
            // 
            this.标准ToolStripMenuItem.Name = "标准ToolStripMenuItem";
            this.标准ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.标准ToolStripMenuItem.Text = "标准";
            // 
            // 科学ToolStripMenuItem
            // 
            this.科学ToolStripMenuItem.Name = "科学ToolStripMenuItem";
            this.科学ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.科学ToolStripMenuItem.Text = "科学";
            // 
            // 程序员ToolStripMenuItem
            // 
            this.程序员ToolStripMenuItem.Name = "程序员ToolStripMenuItem";
            this.程序员ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.程序员ToolStripMenuItem.Text = "程序员";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // 统计信息ToolStripMenuItem
            // 
            this.统计信息ToolStripMenuItem.Name = "统计信息ToolStripMenuItem";
            this.统计信息ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.统计信息ToolStripMenuItem.Text = "统计信息";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtCopy,
            this.txtPast});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(103, 35);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // txtCopy
            // 
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(160, 38);
            this.txtCopy.Text = "复制";
            this.txtCopy.Click += new System.EventHandler(this.txtCopy_Click);
            // 
            // txtPast
            // 
            this.txtPast.Name = "txtPast";
            this.txtPast.Size = new System.Drawing.Size(160, 38);
            this.txtPast.Text = "粘贴";
            this.txtPast.Click += new System.EventHandler(this.txtPast_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.属性ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(109, 35);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.属性ToolStripMenuItem.Text = "属性";
            this.属性ToolStripMenuItem.Click += new System.EventHandler(this.属性ToolStripMenuItem_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(191, 640);
            this.btnZero.Margin = new System.Windows.Forms.Padding(6);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(98, 62);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(308, 640);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(6);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(98, 62);
            this.btnPoint.TabIndex = 6;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 559);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 62);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 559);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 62);
            this.button4.TabIndex = 7;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(191, 559);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 62);
            this.button5.TabIndex = 9;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 478);
            this.button6.Margin = new System.Windows.Forms.Padding(6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 62);
            this.button6.TabIndex = 12;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(308, 478);
            this.button7.Margin = new System.Windows.Forms.Padding(6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 62);
            this.button7.TabIndex = 11;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(74, 478);
            this.button8.Margin = new System.Windows.Forms.Padding(6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 62);
            this.button8.TabIndex = 10;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(191, 397);
            this.button9.Margin = new System.Windows.Forms.Padding(6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 62);
            this.button9.TabIndex = 15;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(308, 397);
            this.button10.Margin = new System.Windows.Forms.Padding(6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 62);
            this.button10.TabIndex = 14;
            this.button10.Tag = "";
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(74, 397);
            this.button11.Margin = new System.Windows.Forms.Padding(6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(98, 62);
            this.button11.TabIndex = 13;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(308, 316);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(98, 62);
            this.btnBackSpace.TabIndex = 16;
            this.btnBackSpace.Text = "<—";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // txtAllClean
            // 
            this.txtAllClean.Location = new System.Drawing.Point(74, 316);
            this.txtAllClean.Margin = new System.Windows.Forms.Padding(6);
            this.txtAllClean.Name = "txtAllClean";
            this.txtAllClean.Size = new System.Drawing.Size(98, 62);
            this.txtAllClean.TabIndex = 17;
            this.txtAllClean.Text = "CE";
            this.txtAllClean.UseVisualStyleBackColor = true;
            this.txtAllClean.Click += new System.EventHandler(this.txtAllClean_Click);
            // 
            // txtClrean
            // 
            this.txtClrean.Location = new System.Drawing.Point(191, 316);
            this.txtClrean.Margin = new System.Windows.Forms.Padding(6);
            this.txtClrean.Name = "txtClrean";
            this.txtClrean.Size = new System.Drawing.Size(98, 62);
            this.txtClrean.TabIndex = 18;
            this.txtClrean.Text = "C";
            this.txtClrean.UseVisualStyleBackColor = true;
            this.txtClrean.Click += new System.EventHandler(this.txtClrean_Click);
            // 
            // txtEqual
            // 
            this.txtEqual.Location = new System.Drawing.Point(425, 640);
            this.txtEqual.Margin = new System.Windows.Forms.Padding(6);
            this.txtEqual.Name = "txtEqual";
            this.txtEqual.Size = new System.Drawing.Size(82, 62);
            this.txtEqual.TabIndex = 19;
            this.txtEqual.Text = "=";
            this.txtEqual.UseVisualStyleBackColor = true;
            this.txtEqual.Click += new System.EventHandler(this.txtEqual_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(425, 559);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(6);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(82, 62);
            this.txtAdd.TabIndex = 20;
            this.txtAdd.Text = "+";
            this.txtAdd.UseVisualStyleBackColor = true;
            this.txtAdd.Click += new System.EventHandler(this.txtOperat_Click);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(425, 478);
            this.txtSub.Margin = new System.Windows.Forms.Padding(6);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(82, 62);
            this.txtSub.TabIndex = 21;
            this.txtSub.Text = "-";
            this.txtSub.UseVisualStyleBackColor = true;
            this.txtSub.Click += new System.EventHandler(this.txtOperat_Click);
            // 
            // txtDiv
            // 
            this.txtDiv.Location = new System.Drawing.Point(425, 316);
            this.txtDiv.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiv.Name = "txtDiv";
            this.txtDiv.Size = new System.Drawing.Size(82, 62);
            this.txtDiv.TabIndex = 22;
            this.txtDiv.Text = "÷";
            this.txtDiv.UseVisualStyleBackColor = true;
            this.txtDiv.Click += new System.EventHandler(this.txtDiv_Click);
            // 
            // txtMR
            // 
            this.txtMR.Location = new System.Drawing.Point(74, 154);
            this.txtMR.Margin = new System.Windows.Forms.Padding(6);
            this.txtMR.Name = "txtMR";
            this.txtMR.Size = new System.Drawing.Size(98, 62);
            this.txtMR.TabIndex = 23;
            this.txtMR.Text = "MR";
            this.txtMR.UseVisualStyleBackColor = true;
            this.txtMR.Click += new System.EventHandler(this.txtMR_Click);
            // 
            // txtMadd
            // 
            this.txtMadd.Location = new System.Drawing.Point(190, 154);
            this.txtMadd.Margin = new System.Windows.Forms.Padding(6);
            this.txtMadd.Name = "txtMadd";
            this.txtMadd.Size = new System.Drawing.Size(98, 62);
            this.txtMadd.TabIndex = 24;
            this.txtMadd.Text = "M+";
            this.txtMadd.UseVisualStyleBackColor = true;
            this.txtMadd.Click += new System.EventHandler(this.txtMoperat);
            // 
            // txtMsub
            // 
            this.txtMsub.Location = new System.Drawing.Point(306, 154);
            this.txtMsub.Margin = new System.Windows.Forms.Padding(6);
            this.txtMsub.Name = "txtMsub";
            this.txtMsub.Size = new System.Drawing.Size(98, 62);
            this.txtMsub.TabIndex = 25;
            this.txtMsub.Text = "M-";
            this.txtMsub.UseVisualStyleBackColor = true;
            this.txtMsub.Click += new System.EventHandler(this.txtMoperat);
            // 
            // txtMclrean
            // 
            this.txtMclrean.Location = new System.Drawing.Point(422, 154);
            this.txtMclrean.Margin = new System.Windows.Forms.Padding(6);
            this.txtMclrean.Name = "txtMclrean";
            this.txtMclrean.Size = new System.Drawing.Size(82, 62);
            this.txtMclrean.TabIndex = 26;
            this.txtMclrean.Text = "MC";
            this.txtMclrean.UseVisualStyleBackColor = true;
            this.txtMclrean.Click += new System.EventHandler(this.txtMclrean_Click);
            // 
            // txtCross
            // 
            this.txtCross.Location = new System.Drawing.Point(426, 397);
            this.txtCross.Margin = new System.Windows.Forms.Padding(6);
            this.txtCross.Name = "txtCross";
            this.txtCross.Size = new System.Drawing.Size(82, 62);
            this.txtCross.TabIndex = 27;
            this.txtCross.Text = "*";
            this.txtCross.UseVisualStyleBackColor = true;
            this.txtCross.Click += new System.EventHandler(this.txtOperat_Click);
            // 
            // txtPOM
            // 
            this.txtPOM.Location = new System.Drawing.Point(74, 640);
            this.txtPOM.Margin = new System.Windows.Forms.Padding(6);
            this.txtPOM.Name = "txtPOM";
            this.txtPOM.Size = new System.Drawing.Size(98, 62);
            this.txtPOM.TabIndex = 28;
            this.txtPOM.Text = "±";
            this.txtPOM.UseVisualStyleBackColor = true;
            this.txtPOM.Click += new System.EventHandler(this.txtPOM_Click);
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(74, 235);
            this.txtMod.Margin = new System.Windows.Forms.Padding(6);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(98, 62);
            this.txtMod.TabIndex = 29;
            this.txtMod.Text = "%";
            this.txtMod.UseVisualStyleBackColor = true;
            this.txtMod.Click += new System.EventHandler(this.txtMod_Click);
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(191, 235);
            this.txtRoot.Margin = new System.Windows.Forms.Padding(6);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(98, 62);
            this.txtRoot.TabIndex = 30;
            this.txtRoot.Text = "√";
            this.txtRoot.UseVisualStyleBackColor = true;
            this.txtRoot.Click += new System.EventHandler(this.txtRoot_Click);
            // 
            // txtSqrt
            // 
            this.txtSqrt.Location = new System.Drawing.Point(308, 235);
            this.txtSqrt.Margin = new System.Windows.Forms.Padding(6);
            this.txtSqrt.Name = "txtSqrt";
            this.txtSqrt.Size = new System.Drawing.Size(98, 62);
            this.txtSqrt.TabIndex = 31;
            this.txtSqrt.Text = "x²";
            this.txtSqrt.UseVisualStyleBackColor = true;
            this.txtSqrt.Click += new System.EventHandler(this.txtSqrt_Click);
            // 
            // txtDao
            // 
            this.txtDao.Location = new System.Drawing.Point(425, 235);
            this.txtDao.Margin = new System.Windows.Forms.Padding(6);
            this.txtDao.Name = "txtDao";
            this.txtDao.Size = new System.Drawing.Size(82, 62);
            this.txtDao.TabIndex = 32;
            this.txtDao.Text = "1/x";
            this.txtDao.UseVisualStyleBackColor = true;
            this.txtDao.Click += new System.EventHandler(this.txtDao_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem1,
            this.粘贴ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 76);
            // 
            // 复制ToolStripMenuItem1
            // 
            this.复制ToolStripMenuItem1.Name = "复制ToolStripMenuItem1";
            this.复制ToolStripMenuItem1.Size = new System.Drawing.Size(136, 36);
            this.复制ToolStripMenuItem1.Text = "复制";
            this.复制ToolStripMenuItem1.Click += new System.EventHandler(this.txtCopy_Click);
            // 
            // 粘贴ToolStripMenuItem1
            // 
            this.粘贴ToolStripMenuItem1.Name = "粘贴ToolStripMenuItem1";
            this.粘贴ToolStripMenuItem1.Size = new System.Drawing.Size(136, 36);
            this.粘贴ToolStripMenuItem1.Text = "粘贴";
            this.粘贴ToolStripMenuItem1.Click += new System.EventHandler(this.txtPast_Click);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(559, 759);
            this.Controls.Add(this.txtDao);
            this.Controls.Add(this.txtSqrt);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtPOM);
            this.Controls.Add(this.txtCross);
            this.Controls.Add(this.txtMclrean);
            this.Controls.Add(this.txtMsub);
            this.Controls.Add(this.txtMadd);
            this.Controls.Add(this.txtMR);
            this.Controls.Add(this.txtDiv);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtEqual);
            this.Controls.Add(this.txtClrean);
            this.Controls.Add(this.txtAllClean);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.FrmCalc_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCalc_KeyPress);
            this.panel1.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button txtAllClean;
        private System.Windows.Forms.Button txtClrean;
        private System.Windows.Forms.Button txtEqual;
        private System.Windows.Forms.Button txtAdd;
        private System.Windows.Forms.Button txtSub;
        private System.Windows.Forms.Button txtDiv;
        private System.Windows.Forms.Button txtMR;
        private System.Windows.Forms.Button txtMadd;
        private System.Windows.Forms.Button txtMsub;
        private System.Windows.Forms.Button txtMclrean;
        private System.Windows.Forms.Button txtCross;
        private System.Windows.Forms.ToolStripMenuItem txtCopy;
        private System.Windows.Forms.ToolStripMenuItem txtPast;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
        private System.Windows.Forms.Button txtPOM;
        private System.Windows.Forms.Button txtMod;
        private System.Windows.Forms.Button txtRoot;
        private System.Windows.Forms.Button txtSqrt;
        private System.Windows.Forms.Button txtDao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem1;
    }
}

