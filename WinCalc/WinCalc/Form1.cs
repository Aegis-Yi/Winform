using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class FrmCalc : Form
    {
        private bool bFirst = true;
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalc_Load(object sender, EventArgs e)
        {
            lblDisp.Text = "";
            lblMem.Text = "";
            lblResult.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bFirst == true) return;
            else
                lblResult.Text = lblResult.Text + "0";
        }

        private void lblNum_Click(object sender, EventArgs e)
        {
            if (bFirst == true)
            {
                lblResult.Text = (sender as Button).Text;
            }
            else
            {
                lblResult.Text = lblResult.Text + (sender as Button).Text;
            }
            bFirst = false;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.IndexOf(".") < 0)
                lblResult.Text = lblResult.Text + ".";
            bFirst = false;
        }

        private void FrmCalc_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FrmCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Button)
                {
                    if ((ctl as Button).Text[0] == ch)
                    {
                        (ctl as Button).Focus();
                        (ctl as Button).PerformClick();
                    }
                }
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (bFirst == true)
                return;
            string str = lblResult.Text;
            int len = str.Length;
            if (len == 1)
            {
                bFirst = true;
                lblResult.Text = "0";
            }
            else
                lblResult.Text = str.Substring(0, len - 1);
        }
    }
}
