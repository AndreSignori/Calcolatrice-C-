namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string num1;
        string num2;
        string segno;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            segno = "+";
            num1 = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string appo = ((Button)sender).Text;


            if (lblDisplay.Text == "0")
                lblDisplay.Text = appo;
            else
                lblDisplay.Text += appo;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btndivisione_Click(object sender, EventArgs e)
        {
            num2 = lblDisplay.Text;
            double appo = Convert.ToDouble(num1);
            double appo1 = Convert.ToDouble(num2);

            if (segno == "+")
                num1 = (appo + appo1).ToString();
            else if (segno == "-")
                num1 = (appo - appo1).ToString();
            else if (segno == "/")
                num1 = (appo / appo1).ToString();
            else
                num1 = (appo * appo1).ToString();


            segno = ((Button)sender).Text;
            label1.Text += num2 + segno;
            lblDisplay.Text = "0";
        }

        private void btnuguale_Click(object sender, EventArgs e)
        {
            num2 = lblDisplay.Text;
            label1.Text += num2;
            double appo = Convert.ToDouble(num1);
            double appo1 = Convert.ToDouble(num2);
            if (segno == "+")
                num1 = (appo + appo1).ToString();
            else if (segno == "-")
                num1 = (appo - appo1).ToString();
            else if (segno == "/")
                num1 = (appo / appo1).ToString();
            else
                num1 = (appo * appo1).ToString();
            lblDisplay.Text = num1;
            num1 = "0";
            segno = "+";
        }

        private void btnsegno_Click(object sender, EventArgs e)
        {
            string appo = lblDisplay.Text;
            appo = (Convert.ToDouble(appo) * -1).ToString();
            lblDisplay.Text = appo;
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            num1 = "0";
            segno = "+";
            lblDisplay.Text = "0";
            label1.Text = "";
            num2 = "0";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            string appo = "";
            for (int i = 0; i < lblDisplay.Text.Length - 1; i++)
            {
                appo += lblDisplay.Text[i];
            }
            lblDisplay.Text = appo;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnc_MouseHover(object sender, EventArgs e)
        {
            avviso.Text = "<<Il tasto c elimina solo una cifra>>";
        }

        private void btnc_MouseLeave(object sender, EventArgs e)
        {
            avviso.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
