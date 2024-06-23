namespace TextSeeker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButtonClick(object sender, EventArgs e)
        {
            // 打开一个新的窗口来添加文本信息
            Form addTextForm = new Form();
            addTextForm.Text = "添加文本信息";
            // 配置窗口其他属性和控件
            addTextForm.ShowDialog();  // 以模态方式打开窗口
        }

        private void searchButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("选中文件：" + filePath);
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
