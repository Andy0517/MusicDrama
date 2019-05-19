using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        //String[] id = new string[] { "123" };
        //String[] passwd = new string[] { "123"};

        private void SignIn_Load(object sender, EventArgs e)
        {
            
        }
        int i = 0;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "123")
            {
                if (txtPasswd.Text == "123")
                {
                    Form1 f = new Form1();
                    f.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("密碼輸入錯誤!!");
                    i++;
                    while (i == 2)
                    {
                        label.Text = "您只剩一次輸入密碼的機會!!";
                        break;
                    }
                    while (i == 3)
                    {
                        Application.Exit();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("此用戶不存在");
            }
        }
    }
}
