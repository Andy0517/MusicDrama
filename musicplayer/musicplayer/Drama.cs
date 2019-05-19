using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace musicplayer
{
    public partial class Drama : Form
    {
        public Drama()
        {
            InitializeComponent();
        }

        PictureBox[] pic = new PictureBox[20];
        string[] drama = new string[] { "愛上哥們", "姊的時代", "1006的房客", "高塔公主", "三明治女的逆襲", "我的愛情不平凡", "極品絕配", "MVP情人", "惡魔在身邊", "喜歡一個人", "通靈少女", "鐘樓愛人", "植劇場－花甲男孩轉大人", "稍息立正我愛你", "我和我的四個男人", "噗通噗通我愛你", "已讀不回的戀人", "我的男孩", "1989一念間", "後菜鳥的燦爛時代" };
        string[] director = new string[] { "陳戎輝", "張佳賢", "陳戎輝", "朱峰", "郝心翔", "張晉榮", "羅安得", "劉俊傑", "毛訓容", "林宏杰", "陳和榆", "郝心翔", "瞿友寧", "黃天仁", "劉恩捷", "郭春暉", "羅安得", "徐輔軍", "郭春暉", "郝心翔" };
        string[] actor = new string[] { "陳楚河", "吳思賢", "李國毅", "王牧語", "張力昂", "揚一展", "吳慷仁", "孫協志", "賀軍翔", "劉以豪", "蔡凡熙", "周湯豪", "盧廣仲", "邱勝翊", "黃仁德", "陳奕", "鍾承翰", "張軒睿", "張立昂", "炎亞綸" };
        string[] actress = new string[] { "賴雅妍", "鍾瑤", "謝欣穎", "孟耿如", "葉星辰", "蔡黃汝", "邵雨薇", "張韶涵", "楊丞琳", "郭雪芙", "郭書瑤", "孟耿如", "海裕芬", "曾之喬", "李毓芬", "魏蔓", "蔡黃汝", "林心如", "邵雨薇", "曾之喬" };
        int[] fee = new int[] { 30, 20, 25, 35, 46, 34, 35, 13, 34, 25, 23, 38, 40, 36, 33, 25, 29, 27, 36, 32 };

        private void Drama_Load(object sender, EventArgs e)
        {
            pic[0] = pic0; pic[1] = pic1; pic[2] = pic2; pic[3] = pic3; pic[4] = pic4; pic[5] = pic5; pic[6] = pic6; pic[7] = pic7; pic[8] = pic8; pic[9] = pic9;
            pic[10] = pic10; pic[11] = pic11; pic[12] = pic12; pic[13] = pic13; pic[14] = pic14; pic[15] = pic15; pic[16] = pic16; pic[17] = pic17; pic[18] = pic18; pic[19] = pic19;
            for (int i = 0; i < drama.Length; i++)
            {
                pic[i].Image = Image.FromFile(drama[i].ToString() + ".jpg");
            }
            label1.Text = drama[0]; label2.Text = drama[1]; label3.Text = drama[2]; label4.Text = drama[3]; label5.Text = drama[4];
            label6.Text = drama[5]; label7.Text = drama[6]; label8.Text = drama[7]; label9.Text = drama[8]; label10.Text = drama[9];
            label12.Text = drama[10]; label13.Text = drama[11]; label14.Text = drama[12]; label15.Text = drama[13]; label16.Text = drama[14];
            label17.Text = drama[15]; label18.Text = drama[16]; label19.Text = drama[17]; label20.Text = drama[18]; label21.Text = drama[19];
            dataGridView1.Visible = false;
            btnColor(btnPic);
        }

        private void getValue(int i)
        {
            Rent r = new Rent();
            r.StrDrama = drama[i];
            r.StrActor = actor[i];
            r.StrActress = actress[i];
            r.StrDirector = director[i];
            r.IFee = fee[i];
            r.setLabel();
            r.Text = "電視劇租借_" + drama[i];
            r.Show();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string name = pb.Name;
            int num = Convert.ToInt32(name.Substring(3));
            getValue(num);
        }

        private void 回到首頁HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choose c = new Choose();
            c.Visible = true;
            this.Visible = false;
        }
        private void 音樂清單MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusicList ml = new MusicList();
            ml.Visible = true;
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

        DataTable GetTable(string sqlcmd)
        {
            String cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MyDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(cnStr);//建立SqlConnection物件cn
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, cn);//用來取得資料表的所有紀錄
            DataSet ds = new DataSet();//當作記憶體的資料庫
            da.Fill(ds);//將SqlDataAdapter物件da取得的員工資料填入ds物件內
            return ds.Tables[0];
        }

        private void btnColor(Button btn)
        {
            Button[] buttons = new Button[] { btnDrama, btnFee, btnPic, btnRole, btnSong };
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Name == btn.Name)
                {
                    buttons[i].BackColor = Color.FromArgb(255, 255, 192);
                }
                else
                {
                    buttons[i].BackColor = SystemColors.Control;
                }
            }
        }

        private void btnDrama_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = GetTable("SELECT * FROM Dramas");
            btnColor(btnDrama);
        }
        private void btnPic_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            dataGridView1.Visible = false;
            btnColor(btnPic);
        }
        private void btnRole_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = GetTable("SELECT * FROM Roles");
            btnColor(btnRole);
        }
        private void btnSong_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = GetTable("SELECT * FROM Songs");
            btnColor(btnSong);
        }
        private void btnFee_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = GetTable("SELECT * FROM Fee");
            btnColor(btnFee);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            getValue(i - 1);
        }
    }
}
