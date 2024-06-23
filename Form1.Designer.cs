namespace TextSeeker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            mainControl1 = new MainControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mainControl1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 451);
            panel1.TabIndex = 0;
            // 
            // mainControl1
            // 
            mainControl1.Location = new Point(0, 0);
            mainControl1.Name = "mainControl1";
            mainControl1.Size = new Size(802, 451);
            mainControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "主界面";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MainControl mainControl;
        private Panel panel1;
        private MainControl mainControl1;
    }
}
