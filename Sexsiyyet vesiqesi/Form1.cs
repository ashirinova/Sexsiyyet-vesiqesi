namespace Sexsiyyet_vesiqesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label14.Text = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label15.Text = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label16.Text = textBox3.Text;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label17.Text = textBox4.Text;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label18.Text = textBox5.Text;
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label19.Text = textBox7.Text;
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label20.Text = textBox11.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            pictureBox1.ImageLocation = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Məlumatlar tam daxil edilməyib", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Məlumatlar yadda saxlanıldı", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}