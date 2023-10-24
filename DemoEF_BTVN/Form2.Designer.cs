namespace DemoEF_BTVN
{
    partial class Form2
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
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            cbEmployee = new ComboBox();
            cbCustomer = new ComboBox();
            cbShip = new ComboBox();
            dgProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(124, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Order Date";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "Employee";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 27);
            textBox3.TabIndex = 3;
            textBox3.Text = "Customer";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(91, 27);
            textBox4.TabIndex = 4;
            textBox4.Text = "Ship";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // cbEmployee
            // 
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(124, 59);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(250, 28);
            cbEmployee.TabIndex = 5;
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(124, 92);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(250, 28);
            cbCustomer.TabIndex = 6;
            // 
            // cbShip
            // 
            cbShip.FormattingEnabled = true;
            cbShip.Location = new Point(124, 126);
            cbShip.Name = "cbShip";
            cbShip.Size = new Size(250, 28);
            cbShip.TabIndex = 7;
            // 
            // dgProduct
            // 
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(27, 174);
            dgProduct.Name = "dgProduct";
            dgProduct.RowHeadersWidth = 51;
            dgProduct.RowTemplate.Height = 29;
            dgProduct.Size = new Size(347, 264);
            dgProduct.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgProduct);
            Controls.Add(cbShip);
            Controls.Add(cbCustomer);
            Controls.Add(cbEmployee);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox cbEmployee;
        private ComboBox cbCustomer;
        private ComboBox cbShip;
        private DataGridView dgProduct;
    }
}