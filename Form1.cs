namespace calculator2
{
    public partial class Form1 : Form
    {
        class ca
        {
            public void p(TextBox tb, Button btn)
            {
                if (tb.Text == "0") { tb.Clear(); }
                if (btn.Text == ".")
                {

                    if (!tb.Text.Contains("."))
                    {
                        tb.Text = tb.Text + btn.Text;
                    }
                }
                else
                {
                    tb.Text = tb.Text + btn.Text;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        string opr = "";
        bool isopr = false;
        double res = 0;



        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ca r = new ca();
            r.p(textBox1, btn);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button bn = (Button)sender;
            opr = bn.Text;
            res = double.Parse(textBox1.Text);
            isopr = true;
            if (isopr == true) { textBox1.Clear(); }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case "+":

                    textBox1.Text = (res + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":

                    textBox1.Text = (res - double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":

                    textBox1.Text = (res / double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":

                    textBox1.Text = (res * double.Parse(textBox1.Text)).ToString();
                    break;

                case "%":

                    textBox1.Text = (res % double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";

        }
    }
}
