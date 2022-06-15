namespace Calculator
{
    public partial class Form1 : Form
    {
        int sign = 0, mul =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && sign ==0 || sign == 1)
            {
                Display.Text = "1";
                sign = 0;
            }
            else
            {
                Display.Text += "1";
                sign = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && sign == 0 || sign ==1)
            {
                Display.Text = "2";
                sign = 0;
            }
            else
            {
                Display.Text += "2";
                sign = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && sign == 0 || sign ==1)
            {
                Display.Text = "3";
                sign = 0;
            }
            else
            {
                Display.Text += "3";
                sign = 0;
            }

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Calculate();
            sign = 1;
            mul = 1;
        }

        public void Calculate()
        {
            int num1, num2, result;
            if(sign == 0) num1 = Convert.ToInt32(Display.Text);
            if(sign == 1) num2 = Convert.ToInt32(Display.Text);
        }
    }
}