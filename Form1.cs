namespace kape
{
    public partial class Form1 : Form
    {
        double Item1 = 120.00;
        double Item2 = 110.00;
        double Item3 = 125.00;
        double Item4 = 150.00;
        double Item5 = 90.00;
        double Item6 = 135.00;
        double Item7 = 155.00;
        double Item8 = 162.00;
        double pointsEarned;
        double Total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                numUd.Enabled = true;
            }
            else
            {
                numUd.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                numUd2.Enabled = true;
            }
            else
            {
                numUd2.Enabled = false;
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked)
            {
                numUd3.Enabled = true;
            }
            else
            {
                numUd3.Enabled = false;
            }
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4.Checked)
            {
                numUd4.Enabled = true;
            }
            else
            {
                numUd4.Enabled = false;
            }
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5.Checked)
            {
                numUd5.Enabled = true;
            }
            else
            {
                numUd5.Enabled = false;
            }
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            if (cb6.Checked)
            {
                numUd6.Enabled = true;
            }
            else
            {
                numUd6.Enabled = false;
            }
        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {
            if (cb7.Checked)
            {
                numUd7.Enabled = true;
            }
            else
            {
                numUd7.Enabled = false;
            }
        }

        private void cb8_CheckedChanged(object sender, EventArgs e)
        {
            if (cb8.Checked)
            {
                numUd8.Enabled = true;
            }
            else
            {
                numUd8.Enabled = false;
            }
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            double orderTotal = 0;

            if (!cb1.Checked && !cb2.Checked && !cb3.Checked && !cb4.Checked && !cb5.Checked && !cb6.Checked && !cb7.Checked && !cb8.Checked)
            {
                MessageBox.Show("Select an Item");
            }
            else if (!rb1.Checked && !rb2.Checked)
            {
                MessageBox.Show("Select Dining Method");
            }
            else
            {
                orderTotal = computeOrders(orderTotal);

                if (rb2.Checked)
                {
                    orderTotal += 10;
                }

                if (cb9.Checked)
                {
                    orderTotal -= 50;
                    pointsEarned = orderTotal * 0.03;
                    lblptns.Text = "Points: " + pointsEarned.ToString();
                }
                else if (!cb9.Checked)
                {
                    lblptns.Text = "Points: ";
                }
                if (orderTotal != Total)
                {
                    Total = orderTotal;
                    lblttl.Text = "Total: " + Total.ToString();
                }

            }
        }
        public double computeOrders(double orderTotal)
        {
            if (cb1.Checked)
            {
                orderTotal += Item1 * double.Parse(numUd.Value.ToString());
            }
            if (cb2.Checked)
            {
                orderTotal += Item2 * double.Parse(numUd2.Value.ToString());
            }
            if (cb3.Checked)
            {
                orderTotal += Item3 * double.Parse(numUd3.Value.ToString());
            }
            if (cb4.Checked)
            {
                orderTotal += Item4 * double.Parse(numUd4.Value.ToString());
            }
            if (cb5.Checked)
            {
                orderTotal += Item5 * double.Parse(numUd5.Value.ToString());
            }
            if (cb6.Checked)
            {
                orderTotal += Item6 * double.Parse(numUd6.Value.ToString());
            }
            if (cb7.Checked)
            {
                orderTotal += Item7 * double.Parse(numUd7.Value.ToString());
            }
            if (cb8.Checked)
            {
                orderTotal += Item8 * double.Parse(numUd8.Value.ToString());
            }
            return orderTotal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numUd_ValueChanged(object sender, EventArgs e)
        {
        
        }
 
    }

}

