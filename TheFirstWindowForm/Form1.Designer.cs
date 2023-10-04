namespace TheFirstWindowsFormApp
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
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(78, 49);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(456, 39);
            this.tbContent.TabIndex = 0;
            this.tbContent.Text = "Something";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(573, 49);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(150, 46);
            this.btSubmit.TabIndex = 1;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbContent);
            this.Name = "Form1";
            this.Text = "The main form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbContent;//1
        private Button btSubmit;
    }
}