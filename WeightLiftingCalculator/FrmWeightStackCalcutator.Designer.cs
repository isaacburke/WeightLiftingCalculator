namespace WeightLiftingCalculator
{
    partial class FrmWeightStackCalcutator
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
            this.grpbxBarWeight = new System.Windows.Forms.GroupBox();
            this.rdobtnMaleBar = new System.Windows.Forms.RadioButton();
            this.rdobtnFemaleBar = new System.Windows.Forms.RadioButton();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.grpbxWeightType = new System.Windows.Forms.GroupBox();
            this.rdobtnLB = new System.Windows.Forms.RadioButton();
            this.rdobtnKG = new System.Windows.Forms.RadioButton();
            this.btnBuild = new System.Windows.Forms.Button();
            this.grpbxBarWeight.SuspendLayout();
            this.grpbxWeightType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxBarWeight
            // 
            this.grpbxBarWeight.Controls.Add(this.rdobtnFemaleBar);
            this.grpbxBarWeight.Controls.Add(this.rdobtnMaleBar);
            this.grpbxBarWeight.Location = new System.Drawing.Point(232, 98);
            this.grpbxBarWeight.Name = "grpbxBarWeight";
            this.grpbxBarWeight.Size = new System.Drawing.Size(293, 39);
            this.grpbxBarWeight.TabIndex = 0;
            this.grpbxBarWeight.TabStop = false;
            this.grpbxBarWeight.Text = "Bar Weight";
            // 
            // rdobtnMaleBar
            // 
            this.rdobtnMaleBar.AutoSize = true;
            this.rdobtnMaleBar.Checked = true;
            this.rdobtnMaleBar.Location = new System.Drawing.Point(6, 19);
            this.rdobtnMaleBar.Name = "rdobtnMaleBar";
            this.rdobtnMaleBar.Size = new System.Drawing.Size(133, 17);
            this.rdobtnMaleBar.TabIndex = 0;
            this.rdobtnMaleBar.TabStop = true;
            this.rdobtnMaleBar.Text = "Male Bar (44LB/20KG)";
            this.rdobtnMaleBar.UseVisualStyleBackColor = true;
            // 
            // rdobtnFemaleBar
            // 
            this.rdobtnFemaleBar.AutoSize = true;
            this.rdobtnFemaleBar.Location = new System.Drawing.Point(145, 19);
            this.rdobtnFemaleBar.Name = "rdobtnFemaleBar";
            this.rdobtnFemaleBar.Size = new System.Drawing.Size(144, 17);
            this.rdobtnFemaleBar.TabIndex = 1;
            this.rdobtnFemaleBar.Text = "Female Bar (33LB/15KG)";
            this.rdobtnFemaleBar.UseVisualStyleBackColor = true;
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Location = new System.Drawing.Point(325, 72);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.Size = new System.Drawing.Size(100, 20);
            this.txtbxWeight.TabIndex = 1;
            this.txtbxWeight.Text = "Weight";
            // 
            // grpbxWeightType
            // 
            this.grpbxWeightType.Controls.Add(this.rdobtnKG);
            this.grpbxWeightType.Controls.Add(this.rdobtnLB);
            this.grpbxWeightType.Location = new System.Drawing.Point(431, 59);
            this.grpbxWeightType.Name = "grpbxWeightType";
            this.grpbxWeightType.Size = new System.Drawing.Size(94, 40);
            this.grpbxWeightType.TabIndex = 2;
            this.grpbxWeightType.TabStop = false;
            // 
            // rdobtnLB
            // 
            this.rdobtnLB.AutoSize = true;
            this.rdobtnLB.Checked = true;
            this.rdobtnLB.Location = new System.Drawing.Point(6, 14);
            this.rdobtnLB.Name = "rdobtnLB";
            this.rdobtnLB.Size = new System.Drawing.Size(38, 17);
            this.rdobtnLB.TabIndex = 0;
            this.rdobtnLB.TabStop = true;
            this.rdobtnLB.Text = "LB";
            this.rdobtnLB.UseVisualStyleBackColor = true;
            this.rdobtnLB.CheckedChanged += new System.EventHandler(this.rdobtnLB_CheckedChanged);
            // 
            // rdobtnKG
            // 
            this.rdobtnKG.AutoSize = true;
            this.rdobtnKG.Location = new System.Drawing.Point(50, 14);
            this.rdobtnKG.Name = "rdobtnKG";
            this.rdobtnKG.Size = new System.Drawing.Size(40, 17);
            this.rdobtnKG.TabIndex = 1;
            this.rdobtnKG.Text = "KG";
            this.rdobtnKG.UseVisualStyleBackColor = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(340, 154);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // FrmWeightStackCalcutator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.grpbxWeightType);
            this.Controls.Add(this.txtbxWeight);
            this.Controls.Add(this.grpbxBarWeight);
            this.Name = "FrmWeightStackCalcutator";
            this.Text = "Weight Stack Calculator";
            this.Load += new System.EventHandler(this.FrmWeightStackCalcutator_Load);
            this.grpbxBarWeight.ResumeLayout(false);
            this.grpbxBarWeight.PerformLayout();
            this.grpbxWeightType.ResumeLayout(false);
            this.grpbxWeightType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxBarWeight;
        private System.Windows.Forms.RadioButton rdobtnMaleBar;
        private System.Windows.Forms.RadioButton rdobtnFemaleBar;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.GroupBox grpbxWeightType;
        private System.Windows.Forms.RadioButton rdobtnLB;
        private System.Windows.Forms.RadioButton rdobtnKG;
        private System.Windows.Forms.Button btnBuild;
    }
}