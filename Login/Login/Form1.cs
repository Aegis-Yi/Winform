using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        private static string[] passname = {"aaa","bbb","ccc","ddd","eee","fff"};
        private static string[] password = { "111","222","333","444","555","666"};
        public static string name;
        public static string word;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButOK_Click(object sender, EventArgs e)
        {
            name=Convert.ToString(TxtName.Text);
            word=Convert.ToString(TxtPassword.Text);
            int n = -1;
            for (int i = 0; i <= 5; i++)
            {
                if (name == passname[i])
                    n = i;                    
            }
            if (n == -1)
                MessageBox.Show("请输入正确的用户名或密码");
            if (n != -1)
            {
                if (word == password[n])
                {
                    if (TxtName.Text != "")
                        TxtName.Items.Add(TxtName.Text);
                    Form2 f2 = new Form2(this);
                    this.Hide();
                    f2.Show();  
                }
                else
                    MessageBox.Show("请输入正确的用户名或密码");
            }
        }
        private void ButExit_Click(object sender, EventArgs e) => this.Close();
    }
}
