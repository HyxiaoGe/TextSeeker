namespace TextSeeker
{
    partial class AddInfoControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(153, 204);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 45);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 3;
            label1.Text = "文件名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 105);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 4;
            label2.Text = "路径";
            // 
            // AddInfoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "AddInfoControl";
            Size = new Size(519, 412);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}
