namespace DemoEF_1
{
    partial class Form1 : Form
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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            tbProductId = new TextBox();
            tbProductName = new TextBox();
            cbProductCategories = new ComboBox();
            nudPrice = new NumericUpDown();
            Refresh = new Button();
            Add = new Button();
            Edit = new Button();
            Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(755, 472);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Delete);
            groupBox1.Controls.Add(Edit);
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(Refresh);
            groupBox1.Controls.Add(nudPrice);
            groupBox1.Controls.Add(cbProductCategories);
            groupBox1.Controls.Add(tbProductName);
            groupBox1.Controls.Add(tbProductId);
            groupBox1.Location = new Point(797, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 472);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tbProductId
            // 
            tbProductId.Location = new Point(97, 64);
            tbProductId.Name = "tbProductId";
            tbProductId.Size = new Size(125, 27);
            tbProductId.TabIndex = 0;
            tbProductId.TextChanged += tbProductId_TextChanged;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(97, 128);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(125, 27);
            tbProductName.TabIndex = 1;
            tbProductName.TextChanged += tbProductName_TextChanged;
            // 
            // cbProductCategories
            // 
            cbProductCategories.FormattingEnabled = true;
            cbProductCategories.Location = new Point(97, 193);
            cbProductCategories.Name = "cbProductCategories";
            cbProductCategories.Size = new Size(151, 28);
            cbProductCategories.TabIndex = 2;
            cbProductCategories.SelectedIndexChanged += cbProductCategories_SelectedIndexChanged;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(97, 258);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 3;
            nudPrice.ValueChanged += nudPrice_ValueChanged;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(52, 330);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(94, 29);
            Refresh.TabIndex = 4;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Add
            // 
            Add.Location = new Point(198, 330);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 5;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(52, 395);
            Edit.Name = "Edit";
            Edit.Size = new Size(94, 29);
            Edit.TabIndex = 6;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(198, 395);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 581);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox tbProductId;
        private Button Delete;
        private Button Edit;
        private Button Add;
        private Button Refresh;
        private NumericUpDown nudPrice;
        private ComboBox cbProductCategories;
        private TextBox tbProductName;
    }
}