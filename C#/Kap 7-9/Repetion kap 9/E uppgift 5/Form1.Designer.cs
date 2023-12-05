namespace E_uppgift_5
{
    partial class Form1
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
            this.btnSlumpa = new System.Windows.Forms.Button();
            this.lblAntal = new System.Windows.Forms.Label();
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSlumpa
            // 
            this.btnSlumpa.Location = new System.Drawing.Point(111, 71);
            this.btnSlumpa.Name = "btnSlumpa";
            this.btnSlumpa.Size = new System.Drawing.Size(75, 23);
            this.btnSlumpa.TabIndex = 0;
            this.btnSlumpa.Text = "Slumpa tal";
            this.btnSlumpa.UseVisualStyleBackColor = true;
            this.btnSlumpa.Click += new System.EventHandler(this.btnSlumpa_Click);
            // 
            // lblAntal
            // 
            this.lblAntal.AutoSize = true;
            this.lblAntal.Location = new System.Drawing.Point(47, 38);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(58, 13);
            this.lblAntal.TabIndex = 1;
            this.lblAntal.Text = "Ange antal";
            // 
            // tbxAntal
            // 
            this.tbxAntal.Location = new System.Drawing.Point(111, 35);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(100, 20);
            this.tbxAntal.TabIndex = 2;
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(217, 35);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResultat.Size = new System.Drawing.Size(150, 132);
            this.tbxResultat.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 193);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.tbxAntal);
            this.Controls.Add(this.lblAntal);
            this.Controls.Add(this.btnSlumpa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSlumpa;
        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.TextBox tbxAntal;
        private System.Windows.Forms.TextBox tbxResultat;
    }
}

