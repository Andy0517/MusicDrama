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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPasswd.Text) || string.IsNullOrEmpty(txtPasswd2.Text))
            {
                MessageBox.Show("請完整填寫使用者名稱及密碼", "錯誤");
            }
            else
            {
                if (Convert.ToString(txtPasswd) == Convert.ToString(txtPasswd2))
                {
                    SignIn si = new SignIn();
                    si.StrUser = txtUser.Text;
                    si.StrPasswd = txtPasswd.Text;
                    MessageBox.Show("成功創建帳戶", "訊息");
                    si.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("密碼與確認密碼不符", "錯誤");
                }
            }
        }
        

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Visible = true;
            this.Visible = false;
        }
    }
}
