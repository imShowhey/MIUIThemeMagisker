using System.Drawing;

namespace MIUIThemeDownloader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.url1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.url2 = new System.Windows.Forms.TextBox();
            this.btn_onlyDeCode = new System.Windows.Forms.Button();
            this.btn_dwnMtzWithDefaultBrowser = new System.Windows.Forms.Button();
            this.btn_openMiuiThemeStore = new System.Windows.Forms.Button();
            this.btn_DeCodeAndDwn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_flashDir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // url1
            // 
            this.url1.Font = new System.Drawing.Font("Consolas", 10F);
            this.url1.Location = new System.Drawing.Point(97, 30);
            this.url1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.url1.Name = "url1";
            this.url1.Size = new System.Drawing.Size(414, 23);
            this.url1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "主题链接:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "下载地址:";
            // 
            // url2
            // 
            this.url2.Font = new System.Drawing.Font("Consolas", 10F);
            this.url2.Location = new System.Drawing.Point(97, 71);
            this.url2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.url2.Name = "url2";
            this.url2.Size = new System.Drawing.Size(414, 23);
            this.url2.TabIndex = 2;
            // 
            // btn_onlyDeCode
            // 
            this.btn_onlyDeCode.Font = new System.Drawing.Font("宋体", 11F);
            this.btn_onlyDeCode.Location = new System.Drawing.Point(20, 122);
            this.btn_onlyDeCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_onlyDeCode.Name = "btn_onlyDeCode";
            this.btn_onlyDeCode.Size = new System.Drawing.Size(180, 29);
            this.btn_onlyDeCode.TabIndex = 4;
            this.btn_onlyDeCode.Text = "仅解析下载地址";
            this.btn_onlyDeCode.UseVisualStyleBackColor = true;
            this.btn_onlyDeCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_dwnMtzWithDefaultBrowser
            // 
            this.btn_dwnMtzWithDefaultBrowser.Font = new System.Drawing.Font("宋体", 11F);
            this.btn_dwnMtzWithDefaultBrowser.Location = new System.Drawing.Point(20, 33);
            this.btn_dwnMtzWithDefaultBrowser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_dwnMtzWithDefaultBrowser.Name = "btn_dwnMtzWithDefaultBrowser";
            this.btn_dwnMtzWithDefaultBrowser.Size = new System.Drawing.Size(180, 29);
            this.btn_dwnMtzWithDefaultBrowser.TabIndex = 5;
            this.btn_dwnMtzWithDefaultBrowser.Text = "使用浏览器下载mtz文件";
            this.btn_dwnMtzWithDefaultBrowser.UseVisualStyleBackColor = true;
            this.btn_dwnMtzWithDefaultBrowser.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_openMiuiThemeStore
            // 
            this.btn_openMiuiThemeStore.Font = new System.Drawing.Font("宋体", 11F);
            this.btn_openMiuiThemeStore.Location = new System.Drawing.Point(20, 76);
            this.btn_openMiuiThemeStore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_openMiuiThemeStore.Name = "btn_openMiuiThemeStore";
            this.btn_openMiuiThemeStore.Size = new System.Drawing.Size(180, 29);
            this.btn_openMiuiThemeStore.TabIndex = 6;
            this.btn_openMiuiThemeStore.Text = "打开主题商店";
            this.btn_openMiuiThemeStore.UseVisualStyleBackColor = true;
            this.btn_openMiuiThemeStore.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_DeCodeAndDwn
            // 
            this.btn_DeCodeAndDwn.Location = new System.Drawing.Point(519, 30);
            this.btn_DeCodeAndDwn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DeCodeAndDwn.Name = "btn_DeCodeAndDwn";
            this.btn_DeCodeAndDwn.Size = new System.Drawing.Size(101, 64);
            this.btn_DeCodeAndDwn.TabIndex = 7;
            this.btn_DeCodeAndDwn.Text = "解析并下载";
            this.btn_DeCodeAndDwn.UseVisualStyleBackColor = true;
            this.btn_DeCodeAndDwn.Click += new System.EventHandler(this.Button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 113);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(467, 35);
            this.progressBar1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "等待下载";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(22, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(716, 160);
            this.listBox1.TabIndex = 10;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDoubleClick);
            // 
            // btn_flashDir
            // 
            this.btn_flashDir.Location = new System.Drawing.Point(762, 89);
            this.btn_flashDir.Name = "btn_flashDir";
            this.btn_flashDir.Size = new System.Drawing.Size(88, 61);
            this.btn_flashDir.TabIndex = 11;
            this.btn_flashDir.Text = "刷新目录";
            this.btn_flashDir.UseVisualStyleBackColor = true;
            this.btn_flashDir.Click += new System.EventHandler(this.btn_flashDir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.url1);
            this.groupBox1.Controls.Add(this.url2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_DeCodeAndDwn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 172);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主要选项";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_dwnMtzWithDefaultBrowser);
            this.groupBox2.Controls.Add(this.btn_onlyDeCode);
            this.groupBox2.Controls.Add(this.btn_openMiuiThemeStore);
            this.groupBox2.Location = new System.Drawing.Point(681, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 172);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其他选项";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_flashDir);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(21, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(880, 225);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "主题列表";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tips：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(70, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(575, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "双击项即可进入主题Magisk模块化打包过程；\r\n你也可以将从别处得到的mtz文件放入Download文件夹内，点击刷新目录按钮后即可将该文件在列表中显示。";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.Location = new System.Drawing.Point(18, 430);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(343, 14);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "如果能在Github上给个Star我将万分感谢！【点这儿】";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 462);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MIUIThemeToMagiskModule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox url2;
        private System.Windows.Forms.Button btn_onlyDeCode;
        private System.Windows.Forms.Button btn_dwnMtzWithDefaultBrowser;
        private System.Windows.Forms.Button btn_openMiuiThemeStore;
        private System.Windows.Forms.Button btn_DeCodeAndDwn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_flashDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
    }
}

