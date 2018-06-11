using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool caps = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButClick(object sender, EventArgs e)
        {
            if (caps == true)
                TextDisp.Text += (sender as Button).Text;
            else
                TextDisp.Text += (sender as Button).Text.ToLower();
        }

        private void ButCaps(object sender, EventArgs e)
        {
            if (caps == false)
                caps = true;
            else
                caps = false;
        }

        private void TextDisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButKeyPress(object sender, KeyPressEventArgs e)
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

        private void ButCpsPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TextBack(object sender, EventArgs e)
        {
            if (TextDisp.Text == "")
                return;
            string str = TextDisp.Text;
            int len = str.Length;
            if (len == 1)
            {
                TextDisp.Text = "";
            }
            else
            {
                TextDisp.Text = str.Substring(0, len - 1);
            }
        }
    }
}
