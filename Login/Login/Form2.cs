using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        private Form1 returnForm1 = null;
        public Form2(Form1 F1)
        {
            InitializeComponent();
            this.returnForm1 = F1;
        }

        private void ButColse_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ReLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.returnForm1.Visible = true;
            this.Close();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TxtUserName.Text = Form1.name;
            TxtUsrePassword.Text = Form1.word;
        }
    }
}
