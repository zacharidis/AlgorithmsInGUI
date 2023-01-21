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

        private void btnFizz_Click(object sender, EventArgs e)
        {
            isEmpty(txtInput.Text);
            lstResults.Items.Clear();
            lstResults.Items.Add($"Solving FizzBuz for number {txtInput.Text}");
        }


        //--- helper method for empty input

        private bool isEmpty(string inputValue) {
        
            if (inputValue == string.Empty) {
                MessageBox.Show("The input value cannot be empty");
                return false;
            }
            return true;
        }
    }
}