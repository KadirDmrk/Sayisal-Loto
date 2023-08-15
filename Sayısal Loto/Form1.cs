namespace Sayısal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int s1, s2, s3, s4;

            s1 = rnd.Next(1, 4);
            s2 = rnd.Next(1, 4);
            s3 = rnd.Next(1, 4);
            s4 = rnd.Next(1, 4);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            // Sayi 1
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Yellow;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            // Sayi 2
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Yellow;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            //sayi 3 
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Yellow;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            // sayi 4 

            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Yellow;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}