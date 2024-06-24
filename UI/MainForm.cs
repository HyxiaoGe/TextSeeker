using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextSeeker.BusinessLogic;

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
            string directory = "E:\\test";
            string searchText = keyword.Text;

            if (!Directory.Exists(directory))
            {
                MessageBox.Show("指定的目录不存在，请检查路径是否正确。");
                return;
            }

            List<string> results = await FileSearchManager.SearchFilesAsync(directory, searchText);
            resultArea.DataSource = results;

        }

    }

}
