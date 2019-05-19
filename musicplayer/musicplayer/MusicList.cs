using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace musicplayer
{
    public partial class MusicList : Form
    {
        public MusicList()
        {
            InitializeComponent();
        }
        private string strValue;
        private string picValue;
        int i = 2;
        public string StrValue
        {
            set
            {
                strValue = value;
            }
        }
        public string PicValue
        {
            set
            {
                picValue = value;
            }
        }

        private void MusicList_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddList al = new AddList();
            al.Show();
            al.Owner = this;//重要的一步，主要是使Form2的Owner指針指向Form1
        }

        public void AddList()
        {
            //物件
            Panel Panel = new Panel();
            Button Button1 = new Button();
            Button Button2 = new Button();
            Label Label = new Label();
            PictureBox PictureBox = new PictureBox();
            
            //修該button
            Button1.BackColor = Color.FromArgb(190, 128, 255, 128);
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.Name = "btn" + i;
            Button1.Width = 15;
            Button1.Height = 15;
            Button1.Location = new Point(73, 0);
            Button1.Click += new EventHandler(Button1_Click);
            Button1.MouseEnter += new EventHandler(Button1_MouseEnter);
            Button1.MouseLeave += new EventHandler(Button1_MouseLeave);
            void Button1_Click(object sender, EventArgs e)
            {
                Label.Text = Interaction.InputBox("請輸入名稱", "確定");
                Lists l = new Lists();
            }
            void Button1_MouseEnter(object sender, EventArgs e)
            {
                Button1.BackColor = Color.FromArgb(128, 255, 128);
            }
            void Button1_MouseLeave(object sender, EventArgs e)
            {
                Button1.BackColor = Color.FromArgb(190, 128, 255, 128);
            }

            //刪除button
            Button2.BackColor = Color.FromArgb(190, 247, 0, 0);
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.FlatAppearance.BorderSize = 0;
            Button2.Name = "btn" + i;
            Button2.Width = 15;
            Button2.Height = 15;
            Button2.Location = new Point(88, 0);
            Button2.Click += new EventHandler(Button2_Click);
            Button2.MouseEnter += new EventHandler(Button2_MouseEnter);
            Button2.MouseLeave += new EventHandler(Button2_MouseLeave);
            void Button2_Click(object sender, EventArgs e)
            {
                this.flowLayoutPanel1.Controls.Remove(Panel);
            }
            void Button2_MouseEnter(object sender, EventArgs e)
            {
                Button2.BackColor = Color.FromArgb(247, 0, 0);
            }
            void Button2_MouseLeave(object sender, EventArgs e)
            {
                Button2.BackColor = Color.FromArgb(190, 247, 0, 0);
            }

            //清單label
            Label.Name = "lab" + i;
            Label.Text = strValue;
            Label.TextAlign = ContentAlignment.MiddleCenter;
            Label.Width = 100;
            Label.Height = 23;
            Label.Location = new Point(2, 98);

            //PictureBox
            PictureBox.Name = "pbx" + i;
            PictureBox.Width = 110;
            PictureBox.Height = 100;
            PictureBox.Location = new Point(0, 0);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.Click += new EventHandler(PictureBox_Click);
            
            void PictureBox_Click(object sender, EventArgs e)
            {
                Lists li = new Lists();//實例化一個Form2窗口  
                li.label1.Text = Label.Text;//設置Form2中string1的值
                li.Text = "音樂清單_"+ Label.Text ;
                li.Show();
            }
            switch (Convert.ToInt32(picValue))
            {
                case 0:
                    PictureBox.Image = Image.FromFile("1m.jpg"); break;
                case 1:
                    PictureBox.Image = Image.FromFile("2m.jpg"); break;
                case 2:
                    PictureBox.Image = Image.FromFile("3m.jpg"); break;
                case 3:
                    PictureBox.Image = Image.FromFile("4m.jpg"); break;
                case 4:
                    PictureBox.Image = Image.FromFile("5m.jpg"); break;
                case 5:
                    PictureBox.Image = Image.FromFile("6m.jpg"); break;
                case 6:
                    PictureBox.Image = Image.FromFile("7m.jpg"); break;
                case 7:
                    PictureBox.Image = Image.FromFile("8m.jpg"); break;
                case 8:
                    PictureBox.Image = Image.FromFile("9m.jpg"); break;
                case 9:
                    PictureBox.Image = Image.FromFile("10m.jpg"); break;
                case 10:
                    PictureBox.Image = Image.FromFile("11m.jpg"); break;
                case 11:
                    PictureBox.Image = Image.FromFile("12m.jpg"); break;
            }

            //Panel
            Panel.BackColor = Color.FromArgb(192, 255, 255);
            Panel.Name = "pal" + i;
            Panel.Width = 103;
            Panel.Height = 120;
            Panel.Controls.Add(Button1);
            Panel.Controls.Add(Button2);
            Panel.Controls.Add(Label);
            Panel.Controls.Add(PictureBox);
            if (i % 2 == 0)
            {
                Panel.Location = new Point(150, 12 + (i - 2) * 75);
            }
            else
            {
                Panel.Location = new Point(24, 12 + (i - 1) * 75);
            }
            this.flowLayoutPanel1.Controls.Add(Panel);
            i++;
        }

        private void 字型ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            FontDialog fontDialog_save = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            try
            {
                fontDialog.Font = fontDialog_save.Font;
                fontDialog.Color = fontDialog_save.Color;
            }
            catch (Exception)
            {

                throw;
            }
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                flowLayoutPanel1.Font = fontDialog.Font;
                flowLayoutPanel1.ForeColor = fontDialog.Color;
            }
            fontDialog_save.Font = fontDialog.Font;
            fontDialog_save.Color = fontDialog.Color;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddList add_list = new AddList();
            add_list.Show();
            add_list.Owner = this;
        }
        private void 回到首頁HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choose c = new Choose();
            c.Visible = true;
            this.Visible = false;
        }
        private void 電視劇租借DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drama d = new Drama();
            d.Visible = true;
            this.Visible = false;
        }
        private void 登出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Visible = true;
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Choose c = new Choose();
            c.Visible = true;
            this.Visible = false;
        }
    }
}

