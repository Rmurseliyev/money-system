namespace money_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            errorProvider1.Clear();

            
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";


            
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;


            
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;


            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Məbləğ daxil edin");
                return;
            }


            
            int mebleg;

            if (!int.TryParse(textBox1.Text, out mebleg))
            {
                errorProvider1.SetError(textBox1, "Məbləğ daxil edin");
                return;
            }


            
            if (mebleg <= 0)
            {
                MessageBox.Show(
                    "Mənfi və ya sıfır məbləğ xırdalanmaz",
                    "Diqqət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            

            
            int say500 = mebleg / 500;
            mebleg = mebleg % 500;

            // 200 manat
            int say200 = mebleg / 200;
            mebleg = mebleg % 200;

            // 100 manat
            int say100 = mebleg / 100;
            mebleg = mebleg % 100;

            // 50 manat
            int say50 = mebleg / 50;
            mebleg = mebleg % 50;

            // 20 manat
            int say20 = mebleg / 20;
            mebleg = mebleg % 20;

            // 10 manat
            int say10 = mebleg / 10;
            mebleg = mebleg % 10;

            // 5 manat
            int say5 = mebleg / 5;
            mebleg = mebleg % 5;

            // 1 manat
            int say1 = mebleg;


            

            label2.Text = say1.ToString();
            label3.Text = say5.ToString();
            label4.Text = say10.ToString();
            label5.Text = say20.ToString();
            label6.Text = say50.ToString();
            label7.Text = say100.ToString();
            label8.Text = say200.ToString();
            label9.Text = say500.ToString();


            

            if (say1 > 0)
            {
                pictureBox1.Visible = true;
                label2.Visible = true;
            }

            if (say5 > 0)
            {
                pictureBox2.Visible = true;
                label3.Visible = true;
            }

            if (say10 > 0)
            {
                pictureBox3.Visible = true;
                label4.Visible = true;
            }

            if (say20 > 0)
            {
                pictureBox4.Visible = true;
                label5.Visible = true;
            }

            if (say50 > 0)
            {
                pictureBox5.Visible = true;
                label6.Visible = true;
            }

            if (say100 > 0)
            {
                pictureBox6.Visible = true;
                label7.Visible = true;
            }

            if (say200 > 0)
            {
                pictureBox7.Visible = true;
                label8.Visible = true;
            }

            if (say500 > 0)
            {
                pictureBox8.Visible = true;
                label9.Visible = true;
            }
        }
    }
}
