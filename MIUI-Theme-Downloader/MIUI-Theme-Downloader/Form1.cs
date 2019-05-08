using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace MIUIThemeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            //默认填写的主题链接
            this.url1.Text = "http://zhuti.xiaomi.com/detail/2d23b3e9-6230-412d-98c9-c04c2c047076";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://zhuti.xiaomi.com/detail/2d23b3e9-6230-412d-98c9-c04c2c047076");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取主题链接
            string dz1 = this.url1.Text;
            //定义新旧字符串
            string oldtext = "http://zhuti.xiaomi.com/detail/";
            string newtext = "http://thm.market.xiaomi.com/thm/download/v2/";
            //修改主题链接
            string dz = string.Empty;
            dz = dz1.Replace(oldtext, newtext);
            //指定请求
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dz);
            //得到返回
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //得到流
            Stream recStream = response.GetResponseStream();
            //编码方式
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            //指定转换为gb2312编码
            StreamReader sr = new StreamReader(recStream, gb2312);
            //以字符串方式得到网页内容
            String content = sr.ReadToEnd();
            //将网页内容进行过滤
            JObject obj = Newtonsoft.Json.Linq.JObject.Parse(content);
            //判断是否获取到正确下载地址
            if (obj["apiCode"].ToString() == "0")
            {
                string dz2 = obj["apiData"]["downloadUrl"].ToString();
                this.url2.Text = dz2;
            }
            else
            {
                this.url2.Text = "请检查网络是否连接或者主题链接是否正确";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
            //判断地址解析是否正确
            if (this.url2.Text == "请检查网络是否连接或者主题链接是否正确")
            {
                MessageBox.Show("无法解析到正确的地址,不能直接下载,请检查网络或者输入是否有误");
            }
            else
            {
                System.Diagnostics.Process.Start(this.url2.Text);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.url2.Text == "请检查网络是否连接或者主题链接是否正确")
            {
                MessageBox.Show("无法解析到正确的地址,不能直接下载,请检查网络或者输入是否有误");
            }
            else
            {
                label3.Text = "正在下载";
                if (url2.Text == null || url2.Text == "")
                {
                    button1_Click(null, null);
                }
                string urlCode = url2.Text.Substring(url2.Text.LastIndexOf('/') + 1);
                string filename = Uri.UnescapeDataString(urlCode);
                Downloader dwn = new Downloader();
                if (dwn.DownloadFile(url2.Text, "Download/" + filename, progressBar1) == 1)
                {
                    label3.Text = "下载完成";
                    btn_flashDir_Click(null, null);
                }

            }

        }

        /// 递归浏览所有文件，string name是你文件夹名
        /// </summary>
        public void LookFile(string pathname)
        {
            if (pathname.Trim().Length == 0)//判断文件名不为空
            {
                return;
            }
            //获取文件夹下的所有文件和文件夹
            string[] files = Directory.GetFileSystemEntries(pathname);
            try
            {
                foreach (string dir in files)
                {
                    if (Directory.Exists(dir))//判断是否为目录，是目录继续递归
                    {
                        LookFile(dir);
                    }
                    else
                    {
                        listBox1.Items.Add(dir);//是文件的话，可以加上你要的操作
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();//防止有些文件无权限访问，屏蔽异常
            }
        }
        private void btn_flashDir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LookFile(System.Windows.Forms.Application.StartupPath + "\\Download");
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            listBox1.SelectedIndex = index;
            if (listBox1.SelectedIndex != -1)
            {
                MIUI_Theme_Magiskizer.frm_Main f1 = new MIUI_Theme_Magiskizer.frm_Main();
                f1.Show();
                f1.btnAdd_Click(listBox1.SelectedItem.ToString(), null);
                //MessageBox.Show(listBox1.SelectedItem.ToString());
            }
        }
    }
}
