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
            this.btnWeightCalculator = new System.Windows.Forms.Button();
            this.btnWeightStackCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeightCalculator
            // 
            this.btnWeightCalculator.Location = new System.Drawing.Point(298, 78);
            this.btnWeightCalculator.Name = "btnWeightCalculator";
            this.btnWeightCalculator.Size = new System.Drawing.Size(125, 23);
            this.btnWeightCalculator.TabIndex = 0;
            this.btnWeightCalculator.Text = "Weight Calculator";
            this.btnWeightCalculator.UseVisualStyleBackColor = true;
            this.btnWeightCalculator.Click += new System.EventHandler(this.btnWeightCalculator_Click);
            // 
            // btnWeightStackCalculator
            // 
            this.btnWeightStackCalculator.Location = new System.Drawing.Point(298, 117);
            this.btnWeightStackCalculator.Name = "btnWeightStackCalculator";
            this.btnWeightStackCalculator.Size = new System.Drawing.Size(125, 23);
            this.btnWeightStackCalculator.TabIndex = 1;
            this.btnWeightStackCalculator.Text = "Weight Stack Calculator";
            this.btnWeightStackCalculator.UseVisualStyleBackColor = true;
            this.btnWeightStackCalculator.Click += new System.EventHandler(this.btnWeightStackCalculator_Click_1);
            // 
            // FrmMaxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWeightStackCalculator);
            this.Controls.Add(this.btnWeightCalculator);
            this.Name = "FrmMaxes";
            this.Text = "Maxes";
            this.Load += new System.EventHandler(this.FrmMaxes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeightCalculator;
        private System.Windows.Forms.Button btnWeightStackCalculator;
    }
}

