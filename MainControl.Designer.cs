namespace TextSeeker
{
    partial class MainControl
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
            mainPanel = new Panel();
            addButton = new Button();
            searchButton = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(addButton);
            mainPanel.Controls.Add(searchButton);
            mainPanel.Location = new Point(3, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(586, 497);
            mainPanel.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(204, 114);
            addButton.Name = "addButton";
            addButton.Size = new Size(137, 38);
            addButton.TabIndex = 2;
            addButton.Text = "添加信息";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(204, 309);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(137, 38);
            searchButton.TabIndex = 3;
            searchButton.Text = "搜索信息";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // MainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Name = "MainControl";
            Size = new Size(589, 500);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel mainPanel;
        private Button addButton;
        private Button searchButton;
    }
}
