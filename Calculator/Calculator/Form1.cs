namespace Calculator
{
    public partial class Form1 : Form
    {
        int sign = 0;
        int add = 0;
        string first = "0", second = "0";
        int f, s;




        public Form1()
        {
            InitializeComponent();
            Display.Text = "START";

        }


        private void Display_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
                if (sign == 0)
                {
                    if (Display.Text == "START")
                    {
                        Display.Text = "1";
                    }
                    else
                    {
                        Display.Text += "1";
                    }
                }
            }
            else if(add == 1)
            {
                if (sign == 0)
                {
                    Display.Text += "1";
                }
                else if (sign == 1)
                {
                first = Display.Text;
                Display.Text = "1";
                sign = 0;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        

        

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            


        }
        private void btnequals_Click(object sender, EventArgs e)
        {
            second = Display.Text;
            f = Convert.ToInt32(first);
            s = Convert.ToInt32(second);

            if (add == 1) Add(f, s);

            f = 0;
            s = 0;
        }

        

        private void btnAC_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            sign = 1;
            add = 1;
        }

        private void Add(int x, int y)
        {
            int result = f + s;
            Display.Text = result.ToString();
            add = 0;
            sign = 1;
        }

       
    }
}