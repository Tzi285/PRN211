namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //1. Tao obj
            OpenFileDialog openFile = new OpenFileDialog();

            //2. Gan property
            openFile.Multiselect = false;//default
            openFile.InitialDirectory = @"C:\";
            openFile.Filer = "Text File|*.txt|CSharp cide|*.cs";

            //3. Hien thi Dialog
            openFile.ShowDialog();

            TextBox1.Text = openFile.FileName;
        }
    }
}