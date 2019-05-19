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
    public partial class Lists : Form
    {
        public Lists()
        {
            InitializeComponent();
        }
        string[] album = new string[] { "", "年華", "忘課", "我愛你 以上", "終極一班2(電視原聲帶)", "雨愛", "偷故事的人", "我們在中場相遇", "剛好遇見你", "幾分之幾", "初學者", "要你知道", "過客", "愛了很久的朋友", "如果雨之後", "亞州通車", "偉大的渺小", "16未成年", "有去無回", "從來不知道", "別來無恙", "在樹上唱歌", "獨家記憶", "魚人", "空", "孤獨的和弦", "大小說家", "SpeXial", "最暖的憂傷", "我的少女時代原聲帶", "范特西" };
        string[] singer = new string[] { "", "林宥嘉", "楊丞琳", "曾沛慈", "曾沛慈", "楊丞琳", "張惠妹", "莫文蔚", "李玉剛", "盧廣仲", "薛之謙", "謝和弦", "阿涵", "田馥甄", "周興哲", "黃明志", "林俊傑", "BY2", "陳零九", "畢書盡", "賴慈泓", "郭靜", "陳小春", "紀佳松", "汪小敏", "蕭煌奇", "林宥嘉", "SpeXial", "田馥甄", "田馥甄", "周杰倫" };
        string[] songs = new string[] { "新增歌曲...", "成全", "忘課", "我不是你該愛的那個人", "一個人想著一個人", "雨愛", "連名帶姓", "慢慢喜歡你", "剛好遇見你", "幾分之幾", "演員", "在沒有你之後", "過客", "愛了很久的朋友", "如果雨之後", "飄向北方", "黑夜問白天", "不夠成熟", "有去無回", "從來不知道", "我的事不關你的事", "心牆", "獨家記憶", "金魚的眼淚", "空", "末班車", "浪費", "慶祝寂寞", "最暖的憂傷", "壞脾氣", "安靜" };
        
        public void Lists_Load(object sender, EventArgs e)
        {
            getList();
            for (int i = 0; i <= songs.GetUpperBound(0); i++)
            {
                cbxSong.Items.Add(songs[i]);
                cbxSong.SelectedIndex = 0;
            }
        }

        static string[] listname = new string[] {  ""};
        static string[] saveSong = new string[] { "" };
        static string[] saveSinger = new string[] { "" };
        static string[] saveAlbum = new string[] { "" };
        string strSinger = "";
        string strSong = "";
        string strAlbum = "";
        private void saveList()
        {
            string strListname = label1.Text; 
            Boolean b = true;
            for (int i = 0; i < listname.Length; i++)
            {
                if (strListname == listname[i])
                {
                    for (int j = 0; j < listBox1.Items.Count; j++)
                    {
                        strSinger += listBox1.Items[j] + "\n";
                        strSong += listBox2.Items[j] + "\n";
                        strAlbum += listBox3.Items[j] + "\n";
                        b = false;
                    }
                    saveSinger[i] = strSinger;
                    saveSong[i] = strSong;
                    saveAlbum[i] = strAlbum;
                }
            }
            if (b)
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    strSinger += listBox1.Items[j] + "\n";
                    strSong += listBox2.Items[j] + "\n";
                    strAlbum += listBox3.Items[j] + "\n";
                }
                System.Array.Resize(ref listname, listname.Length + 1);
                listname[listname.Length - 1] = strListname;
                System.Array.Resize(ref saveSong, saveSong.Length + 1);
                saveSong[saveSong.Length - 1] = strSong;
                System.Array.Resize(ref saveSinger, saveSinger.Length + 1);
                saveSinger[saveSinger.Length - 1] = strSinger;
                System.Array.Resize(ref saveAlbum, saveAlbum.Length + 1);
                saveAlbum[saveAlbum.Length - 1] = strAlbum;
            }
        }

        private void getList()
        {
            string strListname = label1.Text;
            for (int i = 0; i < listname.Length; i++)
            {
                if (listname[i] == strListname)
                {
                    strSinger = saveSinger[i];
                    strSong = saveSong[i];
                    strAlbum = saveAlbum[i];
                    String[] singerLines = strSinger.Split('\n');
                    String[] songLines = strSong.Split('\n');
                    String[] AlbumLines = strAlbum.Split('\n');
                    listBox1.Items.AddRange(singerLines);
                    listBox2.Items.AddRange(songLines);
                    listBox3.Items.AddRange(AlbumLines);
                }
            }
        }

        private void cbxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(cbxSong.SelectedIndex > 0))
            {
                txtSinger.Text = singer[cbxSong.SelectedIndex];
                txtSinger.Enabled = false;
                txtAlbum.Text = album[cbxSong.SelectedIndex];
                txtAlbum.Enabled = false;
            }
            else
            {
                txtSinger.Enabled = true;
                txtAlbum.Enabled = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Contains(cbxSong.Text) == false)
            {
                listBox1.Items.Add(txtSinger.Text);
                listBox2.Items.Add(cbxSong.Text);
                listBox3.Items.Add(txtAlbum.Text);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, false);
                    listBox2.SetSelected(i, false);
                    listBox3.SetSelected(i, false);
                }
            }
            else
            {
                MessageBox.Show("此歌曲已新增");
                listBox1.SetSelected(listBox2.FindStringExact(cbxSong.Text), true);
                listBox2.SetSelected(listBox2.FindStringExact(cbxSong.Text), true);
                listBox3.SetSelected(listBox2.FindStringExact(cbxSong.Text), true);
            }
            /*txtSingerList.AppendText(txtSinger.Text + " \n");
            txtSongList.AppendText(cbxSong.Text + " \n");
            txtAlbumList.AppendText(txtAlbum.Text + " \n");*/
        }

        int select = 0;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 1)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
            }
            else
            {
                select = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(select);
                listBox2.Items.RemoveAt(select);
                listBox3.Items.RemoveAt(select);
            }
            /*String[] songLines = txtSongList.Text.Split('\n');
            String[] singerLines = txtSingerList.Text.Split('\n');
            String[] albumLines = txtAlbumList.Text.Split('\n');
            string strSong = "";
            string strSinger = "";
            string strAlbum = "";

            for (int i = 0; i < songLines.Length-1; i++)
            {
                if (songLines[i] != cbxSong.Text+" ")
                {
                    strSong += songLines[i] + "\r\n";
                    strSinger += singerLines[i] + "\r\n";
                    strAlbum += albumLines[i] + "\r\n";
                }
            }
            txtSongList.Text = strSong;
            txtSingerList.Text = strSinger;
            txtAlbumList.Text = strAlbum;*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            saveList();
            //saveSinger = txtSingerList.Text;
            //saveSong = txtSongList.Text;
            //saveAlbum = txtAlbumList.Text;
            this.Close();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox2.SetSelected(listBox1.SelectedIndex, true);
            listBox3.SetSelected(listBox1.SelectedIndex, true);
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.SetSelected(listBox2.SelectedIndex, true);
            listBox3.SetSelected(listBox2.SelectedIndex, true);
        }

        private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.SetSelected(listBox3.SelectedIndex, true);
            listBox2.SetSelected(listBox3.SelectedIndex, true);
        }
    }
}
