namespace E_uppgift_1
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
            this.lblBetalat = new System.Windows.Forms.Label();
            this.btnKontrollera = new System.Windows.Forms.Button();
            this.tbxBetalat = new System.Windows.Forms.TextBox();
            this.tbxMedlem = new System.Windows.Forms.TextBox();
            this.lblMedlem = new System.Windows.Forms.Label();
            this.tbxRabatt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBetalat
            // 
            this.lblBetalat.AutoSize = true;
            this.lblBetalat.Location = new System.Drawing.Point(17, 25);
            this.lblBetalat.Name = "lblBetalat";
            this.lblBetalat.Size = new System.Drawing.Size(135, 13);
            this.lblBetalat.TabIndex = 0;
            this.lblBetalat.Text = "Hur mycket har du betalat?";
            // 
            // btnKontrollera
            // 
            this.btnKontrollera.Location = new System.Drawing.Point(158, 100);
            this.btnKontrollera.Name = "btnKontrollera";
            this.btnKontrollera.Size = new System.Drawing.Size(75, 23);
            this.btnKontrollera.TabIndex = 1;
            this.btnKontrollera.Text = "Kontrollera";
            this.btnKontrollera.UseVisualStyleBackColor = true;
            this.btnKontrollera.Click += new System.EventHandler(this.btnKontrollera_Click);
            // 
            // tbxBetalat
            // 
            this.tbxBetalat.Location = new System.Drawing.Point(158, 22);
            this.tbxBetalat.Name = "tbxBetalat";
            this.tbxBetalat.Size = new System.Drawing.Size(100, 20);
            this.tbxBetalat.TabIndex = 2;
            // 
            // tbxMedlem
            // 
            this.tbxMedlem.Location = new System.Drawing.Point(158, 48);
            this.tbxMedlem.Name = "tbxMedlem";
            this.tbxMedlem.Size = new System.Drawing.Size(100, 20);
            this.tbxMedlem.TabIndex = 4;
            // 
            // lblMedlem
            // 
            this.lblMedlem.AutoSize = true;
            this.lblMedlem.Location = new System.Drawing.Point(75, 51);
            this.lblMedlem.Name = "lblMedlem";
            this.lblMedlem.Size = new System.Drawing.Size(77, 13);
            this.lblMedlem.TabIndex = 3;
            this.lblMedlem.Text = "Är du medlem?";
            // 
            // tbxRabatt
            // 
            this.tbxRabatt.Location = new System.Drawing.Point(158, 74);
            this.tbxRabatt.Name = "tbxRabatt";
            this.tbxRabatt.ReadOnly = true;
            this.tbxRabatt.Size = new System.Drawing.Size(100, 20);
            this.tbxRabatt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 164);
            this.Controls.Add(this.tbxRabatt);
            this.Controls.Add(this.tbxMedlem);
            this.Controls.Add(this.lblMedlem);
            this.Controls.Add(this.tbxBetalat);
            this.Controls.Add(this.btnKontrollera);
            this.Controls.Add(this.lblBetalat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBetalat;
        private System.Windows.Forms.Button btnKontrollera;
        private System.Windows.Forms.TextBox tbxBetalat;
        private System.Windows.Forms.TextBox tbxMedlem;
        private System.Windows.Forms.Label lblMedlem;
        private System.Windows.Forms.TextBox tbxRabatt;
    }
}

