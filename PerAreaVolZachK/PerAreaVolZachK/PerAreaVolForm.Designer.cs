namespace PerAreaVolZachK
{
    partial class frmPerAreaVol
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
            this.btnQuestion1 = new System.Windows.Forms.Button();
            this.btnQuestion2 = new System.Windows.Forms.Button();
            this.btnQuestion3 = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuestion1
            // 
            this.btnQuestion1.Location = new System.Drawing.Point(12, 12);
            this.btnQuestion1.Name = "btnQuestion1";
            this.btnQuestion1.Size = new System.Drawing.Size(144, 61);
            this.btnQuestion1.TabIndex = 0;
            this.btnQuestion1.Text = "What is the perimeter of a rectangle with a length of 6 and a width of 2?";
            this.btnQuestion1.UseVisualStyleBackColor = true;
            this.btnQuestion1.Click += new System.EventHandler(this.btnQuestion1_Click);
            // 
            // btnQuestion2
            // 
            this.btnQuestion2.Location = new System.Drawing.Point(12, 147);
            this.btnQuestion2.Name = "btnQuestion2";
            this.btnQuestion2.Size = new System.Drawing.Size(144, 59);
            this.btnQuestion2.TabIndex = 1;
            this.btnQuestion2.Text = "What is the area of a circle with radius of 4?";
            this.btnQuestion2.UseVisualStyleBackColor = true;
            this.btnQuestion2.Click += new System.EventHandler(this.btnQuestion2_Click);
            // 
            // btnQuestion3
            // 
            this.btnQuestion3.Location = new System.Drawing.Point(12, 288);
            this.btnQuestion3.Name = "btnQuestion3";
            this.btnQuestion3.Size = new System.Drawing.Size(144, 58);
            this.btnQuestion3.TabIndex = 2;
            this.btnQuestion3.Text = "What is the volume of a sphere with a radius of 6?";
            this.btnQuestion3.UseVisualStyleBackColor = true;
            this.btnQuestion3.Click += new System.EventHandler(this.btnQuestion3_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(488, 36);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(13, 13);
            this.lblAnswer1.TabIndex = 3;
            this.lblAnswer1.Text = "?";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(488, 170);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(13, 13);
            this.lblAnswer2.TabIndex = 4;
            this.lblAnswer2.Text = "?";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(488, 311);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(13, 13);
            this.lblAnswer3.TabIndex = 5;
            this.lblAnswer3.Text = "?";
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 358);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnQuestion3);
            this.Controls.Add(this.btnQuestion2);
            this.Controls.Add(this.btnQuestion1);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, Volume by Zach K";
            this.Load += new System.EventHandler(this.frmPerAreaVol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestion1;
        private System.Windows.Forms.Button btnQuestion2;
        private System.Windows.Forms.Button btnQuestion3;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
    }
}

