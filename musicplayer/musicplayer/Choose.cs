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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private static string strName;
        public string StrName
        {
            set
            {
                strName = value;
            }
        }
        private static string strDrama;
        public string StrDrama
        {
            set
            {
                strDrama = value;
            }
        }
        private static string strDate;
        public string StrDate
        {
            set
            {
                strDate = value;
            }
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label1.Text = strName + "，歡迎使用MusicDrama。　　　　";
            if (string.IsNullOrEmpty(strDrama))
            {
                label2.Text = "";
            }
            else
            {
                label2.Text = "目前正租借【" + strDrama + "】\n歸還日期為 " + strDate;
            }
            toolTip1.SetToolTip(picDrama, "電視劇租借");
            toolTip1.SetToolTip(picMusic, "音樂清單");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string welcome = label1.Text;
            string temp = welcome.Substring(0, 1);
            welcome = welcome.Substring(1, welcome.Length - 1) + temp;
            label1.Text = welcome;
        }

        private void picMusic_Click(object sender, EventArgs e)
        {
            MusicList ml = new MusicList();
            ml.Visible = true;
            this.Visible = false;
        }

        private void picDrama_Click(object sender, EventArgs e)
        {
            Drama d = new Drama();
            d.Visible = true;
            this.Visible = false;
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Visible = true;
            this.Close();
        }
    }
}
