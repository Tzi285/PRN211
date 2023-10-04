namespace TheFirstWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ham xu ly su kien
        private void btSubmit_Click(object sender, EventArgs e)
        {
            //1. khai bao doi tuong control
            TextBox tbFullname = new TextBox();
            Button btNewButton = new Button();

            //2. Thay doi property cho control
            tbFullname.Text = "The new textbox";
            tbFullname.Size = tbContent.Size;
            tbFullname.Location = new Point(tbContent.Location.X,
                tbContent.Location.Y + tbContent.Size.Height + 20);

            btNewButton.Text = "New button";
            btNewButton.Size = btSubmit.Size;
            btNewButton.Location = new Point(btSubmit.Location.X,
                btSubmit.Location.Y + btSubmit.Size.Height + 20);
            btNewButton.Click += new EventHandler(btNewButton_Click);

            //3. Add control vao ds controls cua container (form)
            this.Controls.Add(tbFullname);
            this.Controls.Add(btNewButton);
        }

        private void btNewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nut da bi bam");
        }
    }
}