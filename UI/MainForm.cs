using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextSeeker.BusinessLogic;
using TextSeeker.Models;

namespace TextSeeker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing; // 添加事件处理器
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            VideoService videoService = new VideoService();

            string keywordText = keyword.Text;
            Console.WriteLine(keywordText);
            if (keywordText == "")
            {
                MessageBox.Show("关键字不能为空");
                return;
            }
            string directory = "E:\\test";
            if (!Directory.Exists(directory))
            {
                MessageBox.Show("指定的目录不存在，请检查路径是否正确。");
                return;
            }

            List<Video> results = videoService.getVideoList(keywordText, "");
            if (results.Count == 0)
            {
                dataGridView.Visible = false;
                MessageBox.Show("当前查询无结果");
            }
            else
            {
                dataGridView.DataSource = results;
                dataGridView.Visible = true;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

}
