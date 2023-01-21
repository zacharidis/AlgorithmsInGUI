namespace AlgorithmsInGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
          
            Form form = new AboutForm();
            form.ShowDialog();

        }
    }
}