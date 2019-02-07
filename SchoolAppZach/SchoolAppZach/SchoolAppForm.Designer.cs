namespace SchoolAppZach
{
    partial class frmSchoolApp
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSchoolApp = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblImmaculata = new System.Windows.Forms.Label();
            this.lblSaints = new System.Windows.Forms.Label();
            this.mnuSchoolApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuSchoolApp
            // 
            this.mnuSchoolApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuSchoolApp.Location = new System.Drawing.Point(0, 0);
            this.mnuSchoolApp.Name = "mnuSchoolApp";
            this.mnuSchoolApp.Size = new System.Drawing.Size(284, 24);
            this.mnuSchoolApp.TabIndex = 3;
            this.mnuSchoolApp.Text = "menuStrip3";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblImmaculata
            // 
            this.lblImmaculata.AutoSize = true;
            this.lblImmaculata.Font = new System.Drawing.Font("Onky", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImmaculata.Location = new System.Drawing.Point(-1, 84);
            this.lblImmaculata.Name = "lblImmaculata";
            this.lblImmaculata.Size = new System.Drawing.Size(285, 37);
            this.lblImmaculata.TabIndex = 4;
            this.lblImmaculata.Text = "Immaculata";
            this.lblImmaculata.Click += new System.EventHandler(this.lblMacSaints_Click);
            // 
            // lblSaints
            // 
            this.lblSaints.AutoSize = true;
            this.lblSaints.Font = new System.Drawing.Font("Onky", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaints.Location = new System.Drawing.Point(77, 141);
            this.lblSaints.Name = "lblSaints";
            this.lblSaints.Size = new System.Drawing.Size(131, 34);
            this.lblSaints.TabIndex = 5;
            this.lblSaints.Text = "Saints";
            // 
            // frmSchoolApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSaints);
            this.Controls.Add(this.lblImmaculata);
            this.Controls.Add(this.mnuSchoolApp);
            this.Name = "frmSchoolApp";
            this.Text = "School App by Zach";
            this.mnuSchoolApp.ResumeLayout(false);
            this.mnuSchoolApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mnuSchoolApp;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblImmaculata;
        private System.Windows.Forms.Label lblSaints;
    }
}

