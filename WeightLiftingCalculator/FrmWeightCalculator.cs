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
            float weight = 0;
            try
            {
                weight = float.Parse(txtbx_weight.Text);
            }
            catch
            {
                MessageBox.Show("Weight must be a number.");
            }
            //TODO Check status of radio buttons
            float conversionFactor = 0;
            if (btn_lb.Checked)
            {
                conversionFactor = .453592F;
            }
            else
            {
                conversionFactor = 2.20462F;
            }
            //TODO when btn_Calculate is clicked
            float convertedWeight = weight * conversionFactor;
            //TODO set lbl_Converted_Weight to converted weight
            lbl_Converted_Weight.Text = Convert.ToString(convertedWeight);

           
        }
    }
}
