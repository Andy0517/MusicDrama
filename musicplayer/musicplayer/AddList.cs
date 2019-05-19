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
    public partial class AddList : Form
    {
        public AddList()
        {
            InitializeComponent();
        }

        PictureBox[] pic = new PictureBox[12];
        string[] img = new string[] { "1m", "2m", "3m", "4m", "5m", "6m", "7m", "8m", "9m", "10m", "11m", "12m" };
        int num = 1;

        private void AddList_Load(object sender, EventArgs e)
        {
            pic1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtListname.Text))
            {
                MessageBox.Show("請輸入清單名稱", "錯誤");
            }
            else
            {
                MusicList musiclist = (MusicList)this.Owner;
                musiclist.StrValue = txtListname.Text; 
                musiclist.PicValue = (num - 1).ToString();
                musiclist.AddList();
                this.Close();
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string name = pb.Name;
            num = Convert.ToInt32(name.Substring(3));
            PictureBox[] picture = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12 };
            for (int i = 0; i < pic.Length; i++)
            {
                if (i == num - 1)
                {
                    picture[i].BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    picture[i].BorderStyle = BorderStyle.None;
                }
            }
        }
    }
}

