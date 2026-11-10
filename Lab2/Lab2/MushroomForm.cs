using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        // true when the answer chosen in the box is "Yes"
        private bool Yes(ComboBox box)
        {
            return box.SelectedItem.ToString() == "Yes";
        }

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            if (ringBox.SelectedIndex < 0 || forestBox.SelectedIndex < 0 ||
                gillsBox.SelectedIndex < 0 || convexCupBox.SelectedIndex < 0)
            {
                resultLabel.Text = "Please answer all the questions.";
                return;
            }

            string name;

            if (Yes(ringBox))
            {
                if (Yes(forestBox))
                    name = "Amanite tue-mouche";
                else
                    name = Yes(convexCupBox) ? "Agaric Jaunissant" : "Coprin chevelu";
            }
            else
            {
                if (!Yes(gillsBox))
                    name = "Cepe de bordeau";
                else
                    name = Yes(convexCupBox) ? "Pied bleu" : "Girolle";
            }

            resultLabel.Text = "Your mushroom is: " + name;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ringBox.SelectedIndex = -1;
            forestBox.SelectedIndex = -1;
            gillsBox.SelectedIndex = -1;
            convexCupBox.SelectedIndex = -1;
            resultLabel.Text = "";
        }
    }
}
