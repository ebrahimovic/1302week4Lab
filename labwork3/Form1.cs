namespace labwork3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean lightON = true;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lightON = !lightON;
            flip();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            flip();
        }

        private void flip()
        {
            if (lightON)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                label1.Text = "ON";
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label1.Text = "OFF";
            }
        }
    }
}

