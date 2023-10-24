namespace Lab2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dtpDate = new DateTimePicker();
            cbEmployees = new ComboBox();
            cbCustomers = new ComboBox();
            textBox4 = new TextBox();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox5 = new TextBox();
            tbTotal = new TextBox();
            btAddOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Required Date";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Employee";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 70);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Customer";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(118, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 3;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(118, 41);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(200, 23);
            cbEmployees.TabIndex = 4;
            cbEmployees.SelectedIndexChanged += cbEmployees_SelectedIndexChanged;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(118, 70);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(200, 23);
            cbCustomers.TabIndex = 5;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 99);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            textBox4.Text = "Ship";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(118, 99);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 23);
            comboBox3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(306, 281);
            dataGridView1.TabIndex = 8;
            dataGridView1.SelectionChanged += dataGridView1_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(366, 12);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(312, 362);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(366, 389);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 10;
            textBox5.Text = "Total";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(480, 389);
            tbTotal.Margin = new Padding(3, 2, 3, 2);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(110, 23);
            tbTotal.TabIndex = 11;
            tbTotal.TextChanged += tbTotal_TextChanged_1;
            // 
            // btAddOrder
            // 
            btAddOrder.Location = new Point(595, 389);
            btAddOrder.Margin = new Padding(3, 2, 3, 2);
            btAddOrder.Name = "btAddOrder";
            btAddOrder.Size = new Size(82, 22);
            btAddOrder.TabIndex = 12;
            btAddOrder.Text = "Add";
            btAddOrder.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(btAddOrder);
            Controls.Add(tbTotal);
            Controls.Add(textBox5);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(textBox4);
            Controls.Add(cbCustomers);
            Controls.Add(cbEmployees);
            Controls.Add(dtpDate);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dtpDate;
        private ComboBox cbEmployees;
        private ComboBox cbCustomers;
        private TextBox textBox4;
        private ComboBox comboBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox5;
        private TextBox tbTotal;
        private Button btAddOrder;
        private DataGridView dataGridView1;
    }
}