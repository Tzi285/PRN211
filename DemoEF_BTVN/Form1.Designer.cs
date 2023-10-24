namespace DemoEF_BTVN
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
            cbEmployees = new ComboBox();
            cbCustomers = new ComboBox();
            From = new DateTimePicker();
            To = new DateTimePicker();
            Filter = new Button();
            dataGridView1 = new DataGridView();
            AddOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(85, 28);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(151, 28);
            cbEmployees.TabIndex = 0;
            cbEmployees.SelectedIndexChanged += cbEmployees_SelectedIndexChanged;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(85, 88);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(151, 28);
            cbCustomers.TabIndex = 1;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // From
            // 
            From.Location = new Point(320, 29);
            From.Name = "From";
            From.Size = new Size(250, 27);
            From.TabIndex = 2;
            From.ValueChanged += From_ValueChanged;
            // 
            // To
            // 
            To.Location = new Point(621, 29);
            To.Name = "To";
            To.Size = new Size(250, 27);
            To.TabIndex = 3;
            To.ValueChanged += To_ValueChanged;
            // 
            // Filter
            // 
            Filter.Location = new Point(320, 88);
            Filter.Name = "Filter";
            Filter.Size = new Size(94, 29);
            Filter.TabIndex = 4;
            Filter.Text = "Filer";
            Filter.UseVisualStyleBackColor = true;
            Filter.Click += Filter_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(786, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dgOrders_CellContentClick;
            // 
            // AddOrder
            // 
            AddOrder.Location = new Point(476, 88);
            AddOrder.Name = "AddOrder";
            AddOrder.Size = new Size(94, 29);
            AddOrder.TabIndex = 6;
            AddOrder.Text = "Add Order";
            AddOrder.UseVisualStyleBackColor = true;
            AddOrder.Click += AddOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(AddOrder);
            Controls.Add(dataGridView1);
            Controls.Add(Filter);
            Controls.Add(To);
            Controls.Add(From);
            Controls.Add(cbCustomers);
            Controls.Add(cbEmployees);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbEmployees;
        private ComboBox cbCustomers;
        private DateTimePicker From;
        private DateTimePicker To;
        private Button Filter;
        private DataGridView dataGridView1;
        private Button AddOrder;
    }
}