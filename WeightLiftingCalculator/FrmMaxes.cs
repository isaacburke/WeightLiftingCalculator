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

        private void TESTbtn_makeCalculator_Click(object sender, EventArgs e)
        {
            //TODO remove the following before release
            //The following is for testing of other screens only
            FrmWeightCalculator calc = new FrmWeightCalculator();
            calc.Visible = true;
            
        }
    }
}
