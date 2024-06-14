namespace Grade_Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double en = Convert.ToDouble(txtEnglish.Text);
            double sc = Convert.ToDouble(txtScience.Text);
            double ma = Convert.ToDouble(txtMaths.Text);

            //total marks

            lblTotal.Text = Convert.ToString(Convert.ToDouble(en + sc + ma));

            //avarage

            double to = Convert.ToDouble(lblTotal.Text);

            lblAvarage.Text = Convert.ToString(Convert.ToDouble(to / 3));

            //grade

            double av = Convert.ToDouble(lblAvarage.Text);

            if (av >= 80)
            {
                lblGrade.Text = "A";
            }

            else if (av >= 60)
            {
                lblGrade.Text = "B";
            }

            else if (av >= 40)
            {
                lblGrade.Text = "C";
            }

            else
            {
                lblGrade.Text = "F";
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}