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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(Convert.ToString(txt_passwd) == Convert.ToString(txt_passwd2))
            {
                MessageBox.Show("成功創建帳戶");

            }
            else
            {
                MessageBox.Show("密碼與確認密碼不符");
            }
        }
    }
}
