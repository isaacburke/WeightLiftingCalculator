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
            this.components = new System.ComponentModel.Container();
            this.lbl_ExerciseName = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txtbx_ExerciseName = new System.Windows.Forms.TextBox();
            this.txtbx_weight = new System.Windows.Forms.TextBox();
            this.dtp_ExerciseDate = new System.Windows.Forms.DateTimePicker();
            this.radbtn_kg = new System.Windows.Forms.RadioButton();
            this.radbtn_lb = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_pastExecises = new System.Windows.Forms.DataGridView();
            this.clmn_Exercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_lb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addExercise = new System.Windows.Forms.Button();
            this.btnWeightCalculator = new System.Windows.Forms.Button();
            this.btnWeightStackCalculator = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pastExecises)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ExerciseName
            // 
            this.lbl_ExerciseName.AutoSize = true;
            this.lbl_ExerciseName.Location = new System.Drawing.Point(132, 59);
            this.lbl_ExerciseName.Name = "lbl_ExerciseName";
            this.lbl_ExerciseName.Size = new System.Drawing.Size(47, 13);
            this.lbl_ExerciseName.TabIndex = 0;
            this.lbl_ExerciseName.Text = "Exercise";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(132, 105);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(132, 152);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(41, 13);
            this.lbl_weight.TabIndex = 2;
            this.lbl_weight.Text = "Weight";
            // 
            // txtbx_ExerciseName
            // 
            this.txtbx_ExerciseName.Location = new System.Drawing.Point(135, 75);
            this.txtbx_ExerciseName.Name = "txtbx_ExerciseName";
            this.txtbx_ExerciseName.Size = new System.Drawing.Size(100, 20);
            this.txtbx_ExerciseName.TabIndex = 3;
            // 
            // txtbx_weight
            // 
            this.txtbx_weight.Location = new System.Drawing.Point(135, 168);
            this.txtbx_weight.Name = "txtbx_weight";
            this.txtbx_weight.Size = new System.Drawing.Size(100, 20);
            this.txtbx_weight.TabIndex = 5;
            // 
            // dtp_ExerciseDate
            // 
            this.dtp_ExerciseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ExerciseDate.Location = new System.Drawing.Point(135, 121);
            this.dtp_ExerciseDate.Name = "dtp_ExerciseDate";
            this.dtp_ExerciseDate.Size = new System.Drawing.Size(117, 20);
            this.dtp_ExerciseDate.TabIndex = 6;
            // 
            // radbtn_kg
            // 
            this.radbtn_kg.AutoSize = true;
            this.radbtn_kg.Location = new System.Drawing.Point(37, 3);
            this.radbtn_kg.Name = "radbtn_kg";
            this.radbtn_kg.Size = new System.Drawing.Size(37, 17);
            this.radbtn_kg.TabIndex = 0;
            this.radbtn_kg.Text = "kg";
            this.radbtn_kg.UseVisualStyleBackColor = true;
            // 
            // radbtn_lb
            // 
            this.radbtn_lb.AutoSize = true;
            this.radbtn_lb.Checked = true;
            this.radbtn_lb.Location = new System.Drawing.Point(3, 3);
            this.radbtn_lb.Name = "radbtn_lb";
            this.radbtn_lb.Size = new System.Drawing.Size(33, 17);
            this.radbtn_lb.TabIndex = 1;
            this.radbtn_lb.TabStop = true;
            this.radbtn_lb.Text = "lb";
            this.radbtn_lb.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radbtn_kg);
            this.panel1.Controls.Add(this.radbtn_lb);
            this.panel1.Location = new System.Drawing.Point(242, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 29);
            this.panel1.TabIndex = 9;
            // 
            // dgv_pastExecises
            // 
            this.dgv_pastExecises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pastExecises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_Exercise,
            this.clmn_date,
            this.clmn_lb,
            this.clmn_kg});
            this.dgv_pastExecises.Location = new System.Drawing.Point(297, 230);
            this.dgv_pastExecises.Name = "dgv_pastExecises";
            this.dgv_pastExecises.RowTemplate.Height = 28;
            this.dgv_pastExecises.Size = new System.Drawing.Size(444, 171);
            this.dgv_pastExecises.TabIndex = 10;
            // 
            // clmn_Exercise
            // 
            this.clmn_Exercise.HeaderText = "Exercise";
            this.clmn_Exercise.Name = "clmn_Exercise";
            // 
            // clmn_date
            // 
            this.clmn_date.HeaderText = "Date";
            this.clmn_date.Name = "clmn_date";
            // 
            // clmn_lb
            // 
            this.clmn_lb.HeaderText = "lbs";
            this.clmn_lb.Name = "clmn_lb";
            // 
            // clmn_kg
            // 
            this.clmn_kg.HeaderText = "kgs";
            this.clmn_kg.Name = "clmn_kg";
            // 
            // btn_addExercise
            // 
            this.btn_addExercise.Location = new System.Drawing.Point(135, 230);
            this.btn_addExercise.Name = "btn_addExercise";
            this.btn_addExercise.Size = new System.Drawing.Size(110, 56);
            this.btn_addExercise.TabIndex = 11;
            this.btn_addExercise.Text = "ADD";
            this.btn_addExercise.UseVisualStyleBackColor = true;
            this.btn_addExercise.Click += new System.EventHandler(this.btn_addExercise_Click);
            // 
            // btnWeightCalculator
            // 
            this.btnWeightCalculator.Location = new System.Drawing.Point(495, 73);
            this.btnWeightCalculator.Name = "btnWeightCalculator";
            this.btnWeightCalculator.Size = new System.Drawing.Size(125, 23);
            this.btnWeightCalculator.TabIndex = 0;
            this.btnWeightCalculator.Text = "Weight Calculator";
            this.btnWeightCalculator.UseVisualStyleBackColor = true;
            this.btnWeightCalculator.Click += new System.EventHandler(this.btnWeightCalculator_Click);
            // 
            // btnWeightStackCalculator
            // 
            this.btnWeightStackCalculator.Location = new System.Drawing.Point(495, 121);
            this.btnWeightStackCalculator.Name = "btnWeightStackCalculator";
            this.btnWeightStackCalculator.Size = new System.Drawing.Size(125, 23);
            this.btnWeightStackCalculator.TabIndex = 1;
            this.btnWeightStackCalculator.Text = "Weight Stack Calculator";
            this.btnWeightStackCalculator.UseVisualStyleBackColor = true;
            this.btnWeightStackCalculator.Click += new System.EventHandler(this.btnWeightStackCalculator_Click);
            // 
            // FrmMaxes
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addExercise);
            this.Controls.Add(this.dgv_pastExecises);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_ExerciseDate);
            this.Controls.Add(this.txtbx_weight);
            this.Controls.Add(this.txtbx_ExerciseName);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_ExerciseName);
            this.Controls.Add(this.btnWeightStackCalculator);
            this.Controls.Add(this.btnWeightCalculator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMaxes";
            this.Load += new System.EventHandler(this.FrmMaxes_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pastExecises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label lbl_ExerciseName;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.TextBox txtbx_ExerciseName;
        private System.Windows.Forms.TextBox txtbx_weight;
        private System.Windows.Forms.DateTimePicker dtp_ExerciseDate;
        private System.Windows.Forms.RadioButton radbtn_lb;
        private System.Windows.Forms.RadioButton radbtn_kg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgv_pastExecises;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Exercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_kg;
        private System.Windows.Forms.Button btn_addExercise;
        private System.Windows.Forms.Button btnWeightCalculator;
        private System.Windows.Forms.Button btnWeightStackCalculator;

        #endregion
    }
}

