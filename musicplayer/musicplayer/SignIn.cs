using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicplayer
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
        private string strUser;
        private string strPasswd;
        public string StrUser
        {
            set
            {
                strUser = value;
            }
        }
        public string StrPasswd
        {
            set
            {
                strPasswd = value;
            }
        }
        
        private void name()
        {
            Choose c = new Choose();
            c.StrName = txtId.Text;
            c.Visible = true;
            this.Visible = false;
        }

        int i = 0;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "123")
            {
                if (txtPasswd.Text == "123")
                {
                    MessageBox.Show("登入成功", "訊息");
                    name();
                }
                else
                {
                    MessageBox.Show("密碼輸入錯誤!!", "錯誤");
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
                if (txtId.Text == strUser)
                {
                    if (txtPasswd.Text == strPasswd)
                    {
                        name();
                    }
                    else
                    {
                        MessageBox.Show("密碼輸入錯誤!!", "錯誤");
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
                    MessageBox.Show("此用戶不存在", "錯誤");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Visible = true;
            this.Visible = false;
        }
    }
}

