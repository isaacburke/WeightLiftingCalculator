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
    public partial class FrmWeightStackCalcutator : Form
    {
        public FrmWeightStackCalcutator()
        {
            InitializeComponent();
        }

        private void FrmWeightStackCalcutator_Load(object sender, EventArgs e)
        {
            //Weight is converted to KG if needed
            double weight = 0;
            try
            {
                weight = double.Parse(txtbxWeight.Text);
            }
            catch
            {
                MessageBox.Show("Weight must be a number.");
            }
            //TODO: Weight entered has radio button subtracted
            double conversionFactor = 0;
            if (rdobtnLB.Checked)
            {
                conversionFactor = .453592;
            }
            else
            {
                conversionFactor = 2.20462;
            }
            /*TODO: When "Build" button is clicked, the program calculates 
                    how much weight goes on each side of the bar*/
        }

        private void rdobtnLB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
