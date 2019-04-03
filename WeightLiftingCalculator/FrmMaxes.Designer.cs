namespace WeightLiftingCalculator
{
    partial class FrmMaxes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ExerciseName = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txtbx_ExerciseName = new System.Windows.Forms.TextBox();
            this.txtbx_weight = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpbx_units = new System.Windows.Forms.GroupBox();
            this.radbtn_kg = new System.Windows.Forms.RadioButton();
            this.radbtn_lb = new System.Windows.Forms.RadioButton();
            this.TESTbtn_makeCalculator = new System.Windows.Forms.Button();
            this.grpbx_units.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ExerciseName
            // 
            this.lbl_ExerciseName.AutoSize = true;
            this.lbl_ExerciseName.Location = new System.Drawing.Point(221, 94);
            this.lbl_ExerciseName.Name = "lbl_ExerciseName";
            this.lbl_ExerciseName.Size = new System.Drawing.Size(69, 20);
            this.lbl_ExerciseName.TabIndex = 0;
            this.lbl_ExerciseName.Text = "Exercise";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(222, 175);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(44, 20);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(211, 250);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(59, 20);
            this.lbl_weight.TabIndex = 2;
            this.lbl_weight.Text = "Weight";
            // 
            // txtbx_ExerciseName
            // 
            this.txtbx_ExerciseName.Location = new System.Drawing.Point(104, 140);
            this.txtbx_ExerciseName.Name = "txtbx_ExerciseName";
            this.txtbx_ExerciseName.Size = new System.Drawing.Size(100, 26);
            this.txtbx_ExerciseName.TabIndex = 3;
            // 
            // txtbx_weight
            // 
            this.txtbx_weight.Location = new System.Drawing.Point(107, 282);
            this.txtbx_weight.Name = "txtbx_weight";
            this.txtbx_weight.Size = new System.Drawing.Size(100, 26);
            this.txtbx_weight.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // grpbx_units
            // 
            this.grpbx_units.Controls.Add(this.radbtn_lb);
            this.grpbx_units.Controls.Add(this.radbtn_kg);
            this.grpbx_units.Location = new System.Drawing.Point(292, 266);
            this.grpbx_units.Name = "grpbx_units";
            this.grpbx_units.Size = new System.Drawing.Size(169, 62);
            this.grpbx_units.TabIndex = 7;
            this.grpbx_units.TabStop = false;
            // 
            // radbtn_kg
            // 
            this.radbtn_kg.AutoSize = true;
            this.radbtn_kg.Location = new System.Drawing.Point(100, 25);
            this.radbtn_kg.Name = "radbtn_kg";
            this.radbtn_kg.Size = new System.Drawing.Size(51, 24);
            this.radbtn_kg.TabIndex = 0;
            this.radbtn_kg.Text = "kg";
            this.radbtn_kg.UseVisualStyleBackColor = true;
            // 
            // radbtn_lb
            // 
            this.radbtn_lb.AutoSize = true;
            this.radbtn_lb.Checked = true;
            this.radbtn_lb.Location = new System.Drawing.Point(20, 25);
            this.radbtn_lb.Name = "radbtn_lb";
            this.radbtn_lb.Size = new System.Drawing.Size(46, 24);
            this.radbtn_lb.TabIndex = 1;
            this.radbtn_lb.TabStop = true;
            this.radbtn_lb.Text = "lb";
            this.radbtn_lb.UseVisualStyleBackColor = true;
            // 
            // TESTbtn_makeCalculator
            // 
            this.TESTbtn_makeCalculator.Location = new System.Drawing.Point(411, 29);
            this.TESTbtn_makeCalculator.Name = "TESTbtn_makeCalculator";
            this.TESTbtn_makeCalculator.Size = new System.Drawing.Size(159, 73);
            this.TESTbtn_makeCalculator.TabIndex = 8;
            this.TESTbtn_makeCalculator.Text = "TEST_make a calculator";
            this.TESTbtn_makeCalculator.UseVisualStyleBackColor = true;
            this.TESTbtn_makeCalculator.Click += new System.EventHandler(this.TESTbtn_makeCalculator_Click);
            // 
            // FrmMaxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 692);
            this.Controls.Add(this.TESTbtn_makeCalculator);
            this.Controls.Add(this.grpbx_units);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbx_weight);
            this.Controls.Add(this.txtbx_ExerciseName);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_ExerciseName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMaxes";
            this.Text = "Maxes";
            this.Load += new System.EventHandler(this.FrmMaxes_Load);
            this.grpbx_units.ResumeLayout(false);
            this.grpbx_units.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExerciseName;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.TextBox txtbx_ExerciseName;
        private System.Windows.Forms.TextBox txtbx_weight;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grpbx_units;
        private System.Windows.Forms.RadioButton radbtn_lb;
        private System.Windows.Forms.RadioButton radbtn_kg;
        private System.Windows.Forms.Button TESTbtn_makeCalculator;
    }
}

