using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planer_2
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numberOfPeopleNumericUpDown.Value, 
                fancyDecorationsDinnerChekbox.Checked, 
                healthyOptionCheckbox.Checked);
            DisplayCostOfDinnerParty();
            tooLongLabel.Visible = false;
        }

        private void DisplayCostOfDinnerParty()
        {
            costLabel.Text = dinnerParty.Cost.ToString("c");
        }

        private void numberOfPeopleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfPeopleNumericUpDown.Value;
            DisplayCostOfDinnerParty();
        }

        private void fancyDecorationsDinnerChekbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyDecorationsDinnerChekbox.Checked;
            DisplayCostOfDinnerParty();
        }

        private void healthyOptionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyOptionCheckbox.Checked;
            DisplayCostOfDinnerParty();
        }

        private void cakeWritingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cakeWritingTextBox.Text.Length > 10)
                tooLongLabel.Visible = true;
            else
                tooLongLabel.Visible = false;
        }
    }
}
