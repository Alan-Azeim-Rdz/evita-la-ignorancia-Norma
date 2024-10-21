namespace evita_la_ignorancia_Norma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int point = 0;

        private void BtnSig_Click(object sender, EventArgs e)
        {
            if (RBR1.Checked)
            {
                point++;
            }

            if (RB2R2.Checked)
            {
                point++;
            }

            if (RB3R1.Checked)
            {
                point++;
            }
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            tabControl1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                point++;
            }

            if (radioButton4.Checked)
            {
                point++;
            }

            if (radioButton1.Checked)
            {
                point++;
            }
            tabControl1.SelectedIndex = 2;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                point++;
            }

            if (radioButton16.Checked)
            {
                point++;
            }

            if (radioButton11.Checked)
            {
                point++;
            }
            tabControl1.SelectedIndex = 3;
            groupBox7.Enabled = false;
            groupBox8.Enabled = false;
            groupBox9.Enabled = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
            {
                point++;
            }

            if (radioButton26.Checked)
            {
                point++;
            }

            if (radioButton21.Checked)
            {
                point++;
            }
            tabControl1.SelectedIndex = 4;
            groupBox10.Enabled = false;
            groupBox11.Enabled = false;
            groupBox12.Enabled = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                point++;
            }

            if (radioButton35.Checked)
            {
                point++;
            }

            if (radioButton29.Checked)
            {
                point++;
            }
            tabControl1.SelectedIndex = 5;
            groupBox13.Enabled = false;
            groupBox14.Enabled = false;
            groupBox15.Enabled = false;

            label17.Text = point.ToString();

            if (point>7) 
            {
                MessageBox.Show("Pasaste >:D");
                return;
            }

            MessageBox.Show("Suuerte la proxima");
        }


    }
}
