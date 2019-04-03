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

        private void btn_addExercise_Click(object sender, EventArgs e)
        {
            //TODO: Use Exercise Class
            
            string newExercise = txtbx_ExerciseName.Text;
            DateTime newDate = dtp_ExerciseDate.Value;
            float newWeight = 0F;
            try
            {
                newWeight = float.Parse( txtbx_weight.Text);
            }catch
            {
                MessageBox.Show("Weight must be a number.");
            }
            

            if (radbtn_kg.Checked)
            {
                newWeight *= 2.20462F;
            }

            object[] oArray = { newExercise, newDate, newWeight, newWeight * 0.453592F };

            dgv_pastExecises.Rows.Add(oArray);
            
        }
    }
}
