namespace WeightLiftingCalculator
{
    partial class FrmWeightCalculator
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
            this.txtbx_weight = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_lb = new System.Windows.Forms.RadioButton();
            this.btn_kg = new System.Windows.Forms.RadioButton();
            this.pnl_units = new System.Windows.Forms.Panel();
            this.lbl_Converted_Weight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_units.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_weight
            // 
            this.txtbx_weight.Location = new System.Drawing.Point(343, 103);
            this.txtbx_weight.Name = "txtbx_weight";
            this.txtbx_weight.Size = new System.Drawing.Size(100, 20);
            this.txtbx_weight.TabIndex = 0;
            this.txtbx_weight.Text = "Weight";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(354, 140);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 1;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_lb
            // 
            this.btn_lb.AutoSize = true;
            this.btn_lb.Checked = true;
            this.btn_lb.Location = new System.Drawing.Point(8, 43);
            this.btn_lb.Name = "btn_lb";
            this.btn_lb.Size = new System.Drawing.Size(33, 17);
            this.btn_lb.TabIndex = 3;
            this.btn_lb.TabStop = true;
            this.btn_lb.Text = "lb";
            this.btn_lb.UseVisualStyleBackColor = true;
            // 
            // btn_kg
            // 
            this.btn_kg.AutoSize = true;
            this.btn_kg.Location = new System.Drawing.Point(47, 43);
            this.btn_kg.Name = "btn_kg";
            this.btn_kg.Size = new System.Drawing.Size(37, 17);
            this.btn_kg.TabIndex = 4;
            this.btn_kg.TabStop = true;
            this.btn_kg.Text = "kg";
            this.btn_kg.UseVisualStyleBackColor = true;
            // 
            // pnl_units
            // 
            this.pnl_units.Controls.Add(this.btn_kg);
            this.pnl_units.Controls.Add(this.btn_lb);
            this.pnl_units.Location = new System.Drawing.Point(449, 61);
            this.pnl_units.Name = "pnl_units";
            this.pnl_units.Size = new System.Drawing.Size(97, 91);
            this.pnl_units.TabIndex = 6;
            // 
            // lbl_Converted_Weight
            // 
            this.lbl_Converted_Weight.AutoSize = true;
            this.lbl_Converted_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Converted_Weight.Location = new System.Drawing.Point(12, 9);
            this.lbl_Converted_Weight.Name = "lbl_Converted_Weight";
            this.lbl_Converted_Weight.Size = new System.Drawing.Size(338, 46);
            this.lbl_Converted_Weight.TabIndex = 7;
            this.lbl_Converted_Weight.Text = "Converted Weight";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Converted_Weight);
            this.panel1.Location = new System.Drawing.Point(210, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 65);
            this.panel1.TabIndex = 8;
            // 
            // FrmWeightCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_units);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txtbx_weight);
            this.Name = "FrmWeightCalculator";
            this.Text = "Weight Calculator";
            this.Load += new System.EventHandler(this.FrmWeightCalculator_Load);
            this.pnl_units.ResumeLayout(false);
            this.pnl_units.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_weight;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.RadioButton btn_kg;
        private System.Windows.Forms.RadioButton btn_lb;
        private System.Windows.Forms.Panel pnl_units;
        private System.Windows.Forms.Label lbl_Converted_Weight;
        private System.Windows.Forms.Panel panel1;
    }
}