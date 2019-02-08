namespace HelloWorldIntZachK
{
    partial class frmHelloWorldInt
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
            this.grbLanguages = new System.Windows.Forms.GroupBox();
            this.radPortuguese = new System.Windows.Forms.RadioButton();
            this.radLatin = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLanguages
            // 
            this.grbLanguages.Controls.Add(this.radPortuguese);
            this.grbLanguages.Controls.Add(this.radLatin);
            this.grbLanguages.Controls.Add(this.radGerman);
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Location = new System.Drawing.Point(32, 110);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(200, 100);
            this.grbLanguages.TabIndex = 1;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "Languages";
            this.grbLanguages.Enter += new System.EventHandler(this.grbLanguages_Enter);
            // 
            // radPortuguese
            // 
            this.radPortuguese.AutoSize = true;
            this.radPortuguese.Location = new System.Drawing.Point(104, 68);
            this.radPortuguese.Name = "radPortuguese";
            this.radPortuguese.Size = new System.Drawing.Size(79, 17);
            this.radPortuguese.TabIndex = 5;
            this.radPortuguese.TabStop = true;
            this.radPortuguese.Text = "Portuguese";
            this.radPortuguese.UseVisualStyleBackColor = true;
            this.radPortuguese.CheckedChanged += new System.EventHandler(this.radPortuguese_CheckedChanged);
            // 
            // radLatin
            // 
            this.radLatin.AutoSize = true;
            this.radLatin.Location = new System.Drawing.Point(6, 68);
            this.radLatin.Name = "radLatin";
            this.radLatin.Size = new System.Drawing.Size(48, 17);
            this.radLatin.TabIndex = 4;
            this.radLatin.TabStop = true;
            this.radLatin.Text = "Latin";
            this.radLatin.UseVisualStyleBackColor = true;
            this.radLatin.CheckedChanged += new System.EventHandler(this.radLatin_CheckedChanged_1);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(104, 29);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(62, 17);
            this.radGerman.TabIndex = 3;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "German";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.radGerman_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(6, 29);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 2;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(107, 49);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(35, 13);
            this.lblGreeting.TabIndex = 6;
            this.lblGreeting.Text = "label1";
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.grbLanguages);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International by Zach Kranabetter";
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       //rivate System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.GroupBox grbLanguages;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radPortuguese;
        private System.Windows.Forms.RadioButton radLatin;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.Label lblGreeting;
    }
}

