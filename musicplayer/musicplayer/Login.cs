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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            this.Visible = false;
            su.Visible = true;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            SignIn si = new SignIn();
            this.Visible = false;
            si.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = label1.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
