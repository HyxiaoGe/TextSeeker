namespace TextSeeker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            keywork = new Label();
            keyword = new TextBox();
            searchBtn = new Button();
            addBtn = new Button();
            resultArea = new ListBox();
            result = new Label();
            SuspendLayout();
            // 
            // keywork
            // 
            keywork.AutoSize = true;
            keywork.Location = new Point(46, 64);
            keywork.Name = "keywork";
            keywork.Size = new Size(44, 17);
            keywork.TabIndex = 0;
            keywork.Text = "关键字";
            // 
            // keyword
            // 
            keyword.Location = new Point(122, 61);
            keyword.Name = "keyword";
            keyword.Size = new Size(294, 23);
            keyword.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(461, 61);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "检索";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += btnSearch_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(567, 61);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 3;
            addBtn.Text = "添加";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += btnAdd_Click;
            // 
            // resultArea
            // 
            resultArea.FormattingEnabled = true;
            resultArea.ItemHeight = 17;
            resultArea.Location = new Point(46, 174);
            resultArea.Name = "resultArea";
            resultArea.Size = new Size(596, 242);
            resultArea.TabIndex = 4;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(46, 154);
            result.Name = "result";
            result.Size = new Size(56, 17);
            result.TabIndex = 5;
            result.Text = "结果区域";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(resultArea);
            Controls.Add(addBtn);
            Controls.Add(searchBtn);
            Controls.Add(keyword);
            Controls.Add(keywork);
            Name = "MainForm";
            Text = "主面板";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label keywork;
        private TextBox keyword;
        private Button searchBtn;
        private Button addBtn;
        private ListBox resultArea;
        private Label result;
    }
}