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
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numberOfPeopleNumericUpDown.Value, 
                fancyDecorationsDinnerChekbox.Checked, 
                healthyOptionCheckbox.Checked);
            DisplayCostOfDinnerParty();

            birthdayParty = new BirthdayParty((int)numberOfPeopleOnBirthday.Value,
                fancyDecorationBirthdayChekbox.Checked, cakeWritingTextBox.Text);
            DisplayCostOfBirthdayParty();
        }

        private void DisplayCostOfDinnerParty()
        {
            costDinnerPartyLabel.Text = dinnerParty.Cost.ToString("c");
        }

        private void DisplayCostOfBirthdayParty()
        {
            costBirthdayPartyLabel.Text = birthdayParty.Cost.ToString("c");
            tooLongLabel.Visible = birthdayParty.TooLong;
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
            birthdayParty.CakeWritting = cakeWritingTextBox.Text;
            DisplayCostOfBirthdayParty();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberOfPeopleOnBirthday.Value;
            DisplayCostOfBirthdayParty();
        }

        private void fancyDecorationBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyDecorationBirthdayChekbox.Checked;
            DisplayCostOfBirthdayParty();
        }
    }
}
