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
            // ��һ���µĴ���������ı���Ϣ
            Form addTextForm = new Form();
            addTextForm.Text = "����ı���Ϣ";
            // ���ô����������ԺͿؼ�
            addTextForm.ShowDialog();  // ��ģ̬��ʽ�򿪴���
        }

        private void searchButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("ѡ���ļ���" + filePath);
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
