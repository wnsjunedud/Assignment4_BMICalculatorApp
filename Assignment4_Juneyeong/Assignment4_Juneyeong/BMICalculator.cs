using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/////////////////////////////////////////////////////////////////
//
// Title : Assignment 4 _ S2019 _ COMP123
// The Author's name:Juneyeong Lee
// Author’s student number: 301043697  
// Date last Modified: 07/26/2019
// Program description: Create BMI Calculator in Visual Studio
//
// Revision History:
// 1  Create a Form 
//      &  Add the UI Controls 
//      &  Check the Github
// 2  Check the Solution Structure
//      &  Add Internal Documentation
// 3  Check the Optional App Features
//
/////////////////////////////////////////////////////////////////


namespace Assignment4_Juneyeong
{
    public partial class BMICalculatorForm : Form
    {
        public float Height { get; set; }
        public float Weight { get; set; }
        public float BMI { get; set; }
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImperialTableLayoutPanel.Visible = true;
            MetricTableLayoutPanel.Visible = false;
            WeightTextBox.Text = "inch";
            HeightTextBox.Text = "pound";
            MeterTextBox.Text = "meter";
            KiloTextBox.Text = "kilogram";
            MultiLineTextBox.Visible = false;
            BMITextBox.Visible = false;
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricTableLayoutPanel.Visible = true;
            ImperialTableLayoutPanel.Visible = false;
            WeightTextBox.Text = "inch";
            HeightTextBox.Text = "pound";
            MeterTextBox.Text = "meter";
            KiloTextBox.Text = "kilogram";
            MultiLineTextBox.Visible = false;
            BMITextBox.Visible = false;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            BMITextBox.Visible = true;

            float BMI = 0;
            
            if (ImperialRadioButton.Checked)
            {
                Weight = float.Parse(WeightTextBox.Text);
                Height = float.Parse(HeightTextBox.Text);
                BMI = Weight * 703 / (float)(Math.Pow(Height, 2));
            }
            else
            {
                Weight = float.Parse(KiloTextBox.Text);
                Height = float.Parse(MeterTextBox.Text);
                BMI = Weight / (float)(Math.Pow(Height, 2));
            }
            BMITextBox.Text = BMI.ToString();
            DisplayBMIText();
        }
        private void DisplayBMIText()
        {
            MultiLineTextBox.Visible = true;
            float BMI = float.Parse(BMITextBox.Text);
            if (BMI < 18.5)
            {
                MultiLineTextBox.Text = "Less than 18.5 is Underweight";
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                MultiLineTextBox.Text = "Between 18.5 and 24.9 is Normal";
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                MultiLineTextBox.Text = "Between 25 and 29.9 is Overweight";
            }
            else if (BMI >= 30)
            {
                MultiLineTextBox.Text = "More than 30 is Obese";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            WeightTextBox.Text = "inch";
            HeightTextBox.Text = "pound";
            MeterTextBox.Text = "meter";
            KiloTextBox.Text = "kilogram";
            MultiLineTextBox.Visible = false;
            BMITextBox.Visible = false;
        }

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
