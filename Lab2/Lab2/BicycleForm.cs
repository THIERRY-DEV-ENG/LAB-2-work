using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private int RatePerHour(int hour)
        {
            if (hour < 7) return 500;
            if (hour < 14) return 1000;
            if (hour < 19) return 1500;
            if (hour < 21) return 1000;
            return 500;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int start = (int)startBox.Value;
            int end = (int)endBox.Value;

            detailsBox.Clear();
            totalLabel.Text = "";

            if (start >= end)
            {
                errorLabel.Text = "Error: starting time must be less than ending time.";
                return;
            }

            errorLabel.Text = "";
            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                int rate = RatePerHour(hour);
                total += rate;
                detailsBox.AppendText("Hour " + hour + ": " + rate + " RWF" + Environment.NewLine);
            }

            totalLabel.Text = "Total amount to pay: " + total.ToString("N0") + " RWF";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            startBox.Value = 8;
            endBox.Value = 17;
            detailsBox.Clear();
            totalLabel.Text = "";
            errorLabel.Text = "";
        }
    }
}
