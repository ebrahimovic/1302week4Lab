namespace labwork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double startingNumber) && double.TryParse(textBox2.Text, out double dailyIncrease) && int.TryParse(textBox3.Text, out int numberOfDays))
            {
                listBox1.Items.Clear();
                double dailyAccum = startingNumber;
                for (int i = 1; i <= numberOfDays; i++)
                {

                    
                    double total = dailyAccum;
                    listBox1.Items.Add($"DAY {i}               Approx population{dailyAccum}");
                    dailyAccum = dailyAccum * (1+(dailyIncrease/100));
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
            }
        }
    }
}