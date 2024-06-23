using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSeeker
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // 清除 Panel 中现有的控件
            mainPanel.Controls.Clear();

            // 创建 addControl 的实例
            AddInfoControl addControl = new AddInfoControl();

            // 将 MainControl 添加到 Panel
            mainPanel.Controls.Add(addControl);

            // 设置 MainControl 填充整个 Panel
            addControl.Dock = DockStyle.Fill;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // 清除 Panel 中现有的控件
            mainPanel.Controls.Clear();

            // 创建 addControl 的实例
            SearchInfoControl searchControl = new SearchInfoControl();

            // 将 MainControl 添加到 Panel
            mainPanel.Controls.Add(searchControl);

            // 设置 MainControl 填充整个 Panel
            searchControl.Dock = DockStyle.Fill;
        }
    }
}
