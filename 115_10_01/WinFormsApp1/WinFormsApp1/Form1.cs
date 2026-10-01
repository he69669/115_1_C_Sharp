namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            translateLable.Text = "Buongiorno";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            translateLable.Text = "Buenos d?as";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            translateLable.Text = "Guten Morgen";
        }
    }
}
