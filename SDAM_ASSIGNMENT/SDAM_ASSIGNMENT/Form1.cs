namespace SDAM_ASSIGNMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Exams();
            newform.Show();
            this.Hide();
        }
    }
}