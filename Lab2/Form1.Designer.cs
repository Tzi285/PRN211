namespace Lab2
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
            cbCustomers = new ComboBox();
            cbEmployees = new ComboBox();
            textBox1 = new TextBox();
            dtpFrom = new DateTimePicker();
            textBox2 = new TextBox();
            dtpTo = new DateTimePicker();
            btFilter = new Button();
            btAddOrder = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(10, 27);
            cbCustomers.Margin = new Padding(3, 2, 3, 2);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(133, 23);
            cbCustomers.TabIndex = 0;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(10, 61);
            cbEmployees.Margin = new Padding(3, 2, 3, 2);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(133, 23);
            cbEmployees.TabIndex = 1;
            cbEmployees.SelectedIndexChanged += cbEmployees_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 27);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "From";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(262, 26);
            dtpFrom.Margin = new Padding(3, 2, 3, 2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(219, 23);
            dtpFrom.TabIndex = 3;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 62);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "To";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(262, 62);
            dtpTo.Margin = new Padding(3, 2, 3, 2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(219, 23);
            dtpTo.TabIndex = 5;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // btFilter
            // 
            btFilter.Location = new Point(486, 26);
            btFilter.Margin = new Padding(3, 2, 3, 2);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(82, 22);
            btFilter.TabIndex = 6;
            btFilter.Text = "Filter";
            btFilter.UseVisualStyleBackColor = true;
            // 
            // btAddOrder
            // 
            btAddOrder.Location = new Point(574, 26);
            btAddOrder.Margin = new Padding(3, 2, 3, 2);
            btAddOrder.Name = "btAddOrder";
            btAddOrder.Size = new Size(82, 22);
            btAddOrder.TabIndex = 7;
            btAddOrder.Text = "Add Order";
            btAddOrder.UseVisualStyleBackColor = true;
            btAddOrder.Click += btAddOrder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 86);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(646, 223);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 338);
            Controls.Add(dataGridView1);
            Controls.Add(btAddOrder);
            Controls.Add(btFilter);
            Controls.Add(dtpTo);
            Controls.Add(textBox2);
            Controls.Add(dtpFrom);
            Controls.Add(textBox1);
            Controls.Add(cbEmployees);
            Controls.Add(cbCustomers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCustomers;
        private ComboBox cbEmployees;
        private TextBox textBox1;
        private DateTimePicker dtpFrom;
        private TextBox textBox2;
        private DateTimePicker dtpTo;
        private Button btFilter;
        private Button btAddOrder;
        private DataGridView dataGridView1;
    }
}