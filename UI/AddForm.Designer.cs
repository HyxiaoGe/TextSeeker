namespace TextSeeker
{
    partial class AddForm
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
            keyword = new Label();
            path = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addBtn = new Button();
            SuspendLayout();
            // 
            // keyword
            // 
            keyword.AutoSize = true;
            keyword.Location = new Point(63, 58);
            keyword.Name = "keyword";
            keyword.Size = new Size(44, 17);
            keyword.TabIndex = 0;
            keyword.Text = "关键字";
            // 
            // path
            // 
            path.AutoSize = true;
            path.Location = new Point(64, 136);
            path.Name = "path";
            path.Size = new Size(32, 17);
            path.TabIndex = 1;
            path.Text = "路径";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 23);
            textBox2.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(248, 246);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 4;
            addBtn.Text = "添加";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(path);
            Controls.Add(keyword);
            Name = "AddForm";
            Text = "添加";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label keyword;
        private Label path;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button addBtn;
    }
}