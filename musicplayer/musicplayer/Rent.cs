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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private string strDrama;
        private string strDirector;
        private string strActor;
        private string strActress;
        private int iFee;
        public string StrDrama
        {
            set
            {
                strDrama = value;
            }
        }
        public string StrDirector
        {
            set
            {
                strDirector = value;
            }
        }
        public string StrActor
        {
            set
            {
                strActor = value;
            }
        }
        public string StrActress
        {
            set
            {
                strActress = value;
            }
        }
        public int IFee
        {
            set
            {
                iFee = value;
            }
        }

        private void Rent_Load(object sender, EventArgs e)
        {
        }
        public void setLabel()
        {
            pictureBox1.Image = Image.FromFile(strDrama + ".jpg");
            int[] day = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            lblDrama.Text = strDrama;
            lblDirector.Text = strDirector;
            lblRole.Text = strActor + "、" + strActress;
            for (int i = 0; i <= day.GetUpperBound(0); i++)
            {
                cbxDay.Items.Add(day[i]);
                cbxDay.SelectedIndex = 0;
            }
            txtFee.Text = Convert.ToString(iFee);
            int money = iFee * Convert.ToInt32(cbxDay.SelectedItem);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(cbxDay.SelectedItem);
            int fee = Convert.ToInt32(this.txtFee.Text);
            int money = day * fee;
            lblMessage.Text = "租借【" + strDrama + "】" + cbxDay.SelectedItem + " 天，共 " + money + " 元。";
            btnOk.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String today = DateTime.Now.ToString("yyyy/MM/dd");
            String due = DateTime.Now.AddDays(Convert.ToDouble(cbxDay.SelectedItem)).ToString("yyyy/MM/dd");
            MessageBox.Show("租借成功!!!!" + "\n" + "租借日期：" + today + "\n" + "歸還日期：" + due, "訊息");
            Choose c = new Choose();
            c.StrDrama = strDrama;
            c.StrDate = Convert.ToString(due);
            this.Close();
        }

        private void cbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
        }
    }
}
