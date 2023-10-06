using System.Windows.Forms;

namespace NodepadForm
{
    public partial class Form1 : Form
    {
        MenuStrip mainMenuStrip;

        public Form1()
        {
            InitializeComponent();
            mainMenuStrip = menuStrip2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string fileContent = File.ReadAllText(fileName);
                txtEditor.Text = fileContent;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, txtEditor.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if there is content in the TextBox
            if (txtEditor.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save File", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // Save the file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;
                        File.WriteAllText(fileName, txtEditor.Text);
                    }
                    // After saving, exit the application
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    // Don't save, exit the application
                    Application.Exit();
                }
                // If the user selects "Cancel," do nothing
            }
            else
            {
                // If there is no content, exit the application without displaying a dialog
                Application.Exit();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            //User choose font and enter
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                txtEditor.Font = selectedFont;
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                txtEditor.ForeColor = selectedColor;
            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new child window
            Form newForm = new Form();
            TextBox newTextBox = new TextBox();

            // Configure the TextBox on the new form
            newTextBox.Multiline = true;
            newTextBox.Dock = DockStyle.Fill;

            // Add the TextBox to the new form
            newForm.Controls.Add(newTextBox);
            newForm.Text = "New Window";

            // Set the menu strip of the new form to the main menu strip
            newForm.Controls.Add(mainMenuStrip); // Add main menu strip to the new form

            // Show the new child window
            newForm.Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, txtEditor.Text);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}