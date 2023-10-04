namespace Demo
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            menuStrip3 = new MenuStrip();
            menuStrip4 = new MenuStrip();
            menuStrip5 = new MenuStrip();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 76);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 52);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Location = new Point(0, 28);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(800, 24);
            menuStrip3.TabIndex = 2;
            menuStrip3.Text = "menuStrip3";
            // 
            // menuStrip4
            // 
            menuStrip4.ImageScalingSize = new Size(20, 20);
            menuStrip4.Location = new Point(0, 0);
            menuStrip4.Name = "menuStrip4";
            menuStrip4.Size = new Size(800, 28);
            menuStrip4.TabIndex = 3;
            menuStrip4.Text = "menuStrip4";
            menuStrip4.ItemClicked += menuStrip4_ItemClicked;
            // 
            // menuStrip5
            // 
            menuStrip5.ImageScalingSize = new Size(20, 20);
            menuStrip5.Location = new Point(0, 100);
            menuStrip5.Name = "menuStrip5";
            menuStrip5.Size = new Size(800, 24);
            menuStrip5.TabIndex = 4;
            menuStrip5.Text = "menuStrip5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip5);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            Controls.Add(menuStrip4);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private MenuStrip menuStrip4;
        private MenuStrip menuStrip5;
    }
}