using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightLiftingCalculator
{
    public partial class FrmWeightCalculator : Form
    {
        public FrmWeightCalculator()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //TODO Convert string in txtbx_weight to float with a try parse
            double weight = 0;
            try
            {
                weight = double.Parse(txtbx_weight.Text);
            }
            catch
            {
                MessageBox.Show("Weight must be a number.");
            }
            //TODO Check status of radio buttons
            double conversionFactor = 0;
            string weightUnit = "";
            if (btn_lb.Checked)
            {
                conversionFactor = .453592;
                weightUnit = "LBS";
            }
            else
            {
                conversionFactor = 2.20462;
                weightUnit = "KGS";
            }
            //TODO when btn_Calculate is clicked
            double convertedWeight = weight * conversionFactor;
            //TODO set lbl_Converted_Weight to converted weight

            lbl_Converted_Weight.Text = Convert.ToString((Math.Round(convertedWeight, 2)) + " " + weightUnit);


        }

        private void FrmWeightCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
