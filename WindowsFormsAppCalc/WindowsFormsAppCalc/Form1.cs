using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalc
{
    public partial class FrmCalc : Form
    {
        private bool c = false;
        private double a = 0;
        private string curText = "";
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNum_Leave(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtNum.Text);
            txtNum.Text = num.ToString("###,###,##0.00");
            num = Convert.ToDouble(txtNum.Text);
            if (num % 1 == 0)
                txtNum.Text = num.ToString("###,###,##0");
            if (txtNum.Text.Length > 0)
            {
                if (c == true)
                {
                    c = false;
                    txtNum.Text = "";
                    txtNum.Text = Convert.ToString(a);
                }
                num = Convert.ToDouble(txtNum.Text);
                if (txtNum.Text.Length < 1)
                    return;
                if (txtPrice.Text.Length < 1)
                    return;
                num = 0.0;
                try
                {
                    num = Convert.ToDouble(txtNum.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show("数量不正确, 请重新输入!");
                    txtNum.Text = curText;
                    txtNum.Focus();
                }
                double price = 0.0;
                try
                {
                    price = Convert.ToDouble(txtPrice.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show("单价不正确, 请重新输入!");
                    txtPrice.Text = curText;
                    txtPrice.Focus();
                }
                txtNum.Text = Convert.ToString(num);
                price = Convert.ToDouble(txtPrice.Text);
                txtPrice.Text = price.ToString("###,###,##0.00");
                double amnt = num * price;
                txtMoney.Text = amnt.ToString("###,###,##0.00");
            }
        }
        private void txtMoney_Leave(object sender, EventArgs e)
        {
            if (txtNum.Text.Length < 1)
                return;
            if (txtMoney.Text.Length < 1)
                return;
            double amnt = 0.0;
            try
            {
                amnt = Convert.ToDouble(txtMoney.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("金额不正确, 请重新输入!");
                txtMoney.Text = curText;
                txtMoney.Focus();
            }
            if (c == true)
            {
                c = false;
                txtNum.Text = "";
                txtNum.Text = Convert.ToString(a);
            }
            double num = Convert.ToDouble(txtNum.Text);
            amnt = Convert.ToDouble(txtMoney.Text);
            double price = amnt / num;
            txtPrice.Text = price.ToString();
            txtPrice.Text = price.ToString("###,###,##0.00");
            txtMoney.Text = amnt.ToString("###,###,##0.00");
        }

        private void txtMoney_enter(object sender, EventArgs e)
        {
            curText = (sender as TextBox).Text;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNum.SelectedText != "")
                Clipboard.SetDataObject(txtNum.SelectedText);
            if (txtPrice.SelectedText != "")
                Clipboard.SetDataObject(txtPrice.SelectedText);
            if (txtMoney.SelectedText != "")
                Clipboard.SetDataObject(txtMoney.SelectedText);
            //SendKeys.SendWait("^{c}");
            MessageBox.Show("已复制到剪切板");
        }

        private void txtCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Clipboard.GetText();
            string result = System.Text.RegularExpressions.Regex.Replace(str, @"[^0-9]+","");
            Clipboard.SetText(result);
            Clipboard.GetText();
            SendKeys.SendWait("^{v}");
        }

        private void txtIntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtNum.Text);
            num = Convert.ToInt32(num);
            c = true;
            a = num;
        }

        private void txtDouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = false;
        }
    }
}
