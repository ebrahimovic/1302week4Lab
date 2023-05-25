namespace labwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double speed) && double.TryParse(textBox2.Text, out double hours))
            {
                listBox1.Items.Clear();
                for (int i = 1; i <= hours; i++)
                {
                    double distance = speed * i;
                    listBox1.Items.Add($"After hour {i}, the distance is {distance} miles.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}