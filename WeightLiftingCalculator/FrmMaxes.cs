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
    public partial class FrmMaxes : Form
    {
        public FrmMaxes()
        {
            InitializeComponent();
        }

        private void FrmMaxes_Load(object sender, EventArgs e)
        {

        }

        private void btnWeightCalculator_Click(object sender, EventArgs e)
        {
            FrmWeightCalculator calc = new FrmWeightCalculator();
            calc.Visible = true;
        }


        private void btnWeightStackCalculator_Click_1(object sender, EventArgs e)
        {
            FrmWeightStackCalcutator calc = new FrmWeightStackCalcutator();
            calc.Visible = true;
        }
    }
}
