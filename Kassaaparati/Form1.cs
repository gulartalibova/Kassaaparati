using MessagingToolkit.QRCode.Codec;

namespace Kassaaparati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal total = 0.0M;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
                         Kod:101 | Kurassan
                         Kod:102 | Cola
                         Kod:103 | Corek
                         Kod:104 |Seker
                       ");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] code = { "101", "102", "103", "104" };
            string[] name = { "Kurassan", "Cola", "Corek", "Seker" };
            decimal[] price = { 0.75M, 0.60M, 0.90M, 0.65M };

            if (textBox1.Text == code[0])
            {
                listBox1.Items.Add($"Kod:{code[0]} | Ad:{name[0]} | Qiymet:{price[0]} azn");
                total = total + price[0];
            }
            else if (textBox1.Text == code[1])
            {
                listBox1.Items.Add($"Kod:{code[1]} | Ad:{name[1]} | Qiymet:{price[1]}azn");
                total = total + price[1];
            }
            else if (textBox1.Text == code[2])
            {
                listBox1.Items.Add($"Kod:{code[2]} | Ad:{name[2]} | Qiymet:{price[2]}azn");
                total = total + price[2];
            }
            else if (textBox1.Text == code[3])
            {
                listBox1.Items.Add($"Kod:{code[3]} | Ad:{name[3]} | Qiymet:{price[3]}azn");
                total = total + price[3];
            }
            Umumi.Text = total.ToString() + " " + " azn";

            decimal edv = total / 100;
            decimal per = edv * 18;

            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureBox1.Image = encoder.Encode(per.ToString());

            //pictureBox1.Image = encoder.Encode(total.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btnSifir_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btnX_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
        }

        private void odenilen_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHesab_Click(object sender, EventArgs e)
        {
            decimal paid = Convert.ToDecimal(textBox2.Text);
            if (paid < total)
            {
                Error.Visible = true;

            }
            else
            {
                decimal ret = paid - total;
                pay.Text = paid.ToString() + " " + " azn";
                returned.Text = ret.ToString() + " " + " azn";
            }

            
          


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
