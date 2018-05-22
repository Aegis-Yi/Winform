using System;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class FrmCalc : Form
    {
        private double a = 0;
        private double b = 0;
        private double c = 0;
        private string str1;
        private string str2;
        private bool bFirst = true;
        private bool bSecond = true;
        private bool bThird = true;

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

        private void lblDisp_Click(object sender, EventArgs e)
        {
        }

        private void txtAllClean_Click(object sender, EventArgs e)
        {
            lblDisp.Text = "";
            lblResult.Text = "0";
            bFirst = true;
            bSecond = true;
        }

        private void txtClrean_Click(object sender, EventArgs e)
        {
            if (bFirst == true)
                return;
            else
                lblResult.Text = "0";
            bFirst = true;
        }

        private void txtOperat_Click(object sender, EventArgs e)
        {
            if (bFirst == false && bSecond == true)
            {
                a = Convert.ToDouble(lblResult.Text);
                str1 = (sender as Button).Text;
                lblDisp.Text = Convert.ToString(a) + (sender as Button).Text;
                lblResult.Text = "0";
            }
            else
                return;
            bFirst = true;
            bSecond = false;
        }

        private void txtEqual_Click(object sender, EventArgs e)
        {
            double m = 0;
            if (str1 != "" && bSecond == false)
            {
                b = Convert.ToDouble(lblResult.Text);
                switch (str1)
                {
                    case "+": m = a + b; break;
                    case "-": m = a - b; break;
                    case "*": m = a * b; break;
                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("除数不能为0");
                            return;
                        }
                        else
                            m = a / b;
                        break;
                }
            }
            else
                return;
            lblDisp.Text = "";
            lblResult.Text = Convert.ToString(m);
            bSecond = true;
        }

        private void txtDiv_Click(object sender, EventArgs e)
        {
            if (bFirst == false && bSecond == true)
            {
                a = Convert.ToDouble(lblResult.Text);
                str1 = "/";
                lblDisp.Text = lblResult.Text + (sender as Button).Text;
                lblResult.Text = "0";
            }
            else
                return;
            bFirst = true;
            bSecond = false;
        }

        private void txtMoperat(object sender, EventArgs e)
        {
            str2 = (sender as Button).Text;
            double m = Convert.ToDouble(lblResult.Text);
            switch (str2)
            {
                case "M+": c += m; break;
                case "M-": c -= m; break;
            }
            lblMem.Text = "M";
            bThird = false;
        }

        private void txtMclrean_Click(object sender, EventArgs e)
        {
            c = 0;
            lblMem.Text = "";
            bThird = true;
        }

        private void txtMR_Click(object sender, EventArgs e)
        {
            if (bThird == true)
                return;
            lblResult.Text = Convert.ToString(c);
        }

        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nature form = new nature();
            form.ShowDialog();
        }

        private void txtPOM_Click(object sender, EventArgs e)
        {
            if (bFirst == true)
                return;
            if (lblResult.Text.IndexOf("-") < 0)
                lblResult.Text = "-" + lblResult.Text;
            else
                lblResult.Text = lblResult.Text.Replace("-", "");
        }
    }
}