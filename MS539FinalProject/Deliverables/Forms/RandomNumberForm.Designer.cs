
namespace MS539FinalProject.Deliverables.Forms
{
    partial class RandomNumberForm
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
            this.lblRandomNumberCount = new System.Windows.Forms.Label();
            this.tbRandomNumberCount = new System.Windows.Forms.TextBox();
            this.cbSaveRandomNumbers = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbInstructions = new System.Windows.Forms.TextBox();
            this.rtbNumbers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblRandomNumberCount
            // 
            this.lblRandomNumberCount.AutoSize = true;
            this.lblRandomNumberCount.Location = new System.Drawing.Point(165, 60);
            this.lblRandomNumberCount.Name = "lblRandomNumberCount";
            this.lblRandomNumberCount.Size = new System.Drawing.Size(35, 13);
            this.lblRandomNumberCount.TabIndex = 0;
            this.lblRandomNumberCount.Text = "Count";
            // 
            // tbRandomNumberCount
            // 
            this.tbRandomNumberCount.Location = new System.Drawing.Point(207, 60);
            this.tbRandomNumberCount.Name = "tbRandomNumberCount";
            this.tbRandomNumberCount.Size = new System.Drawing.Size(100, 20);
            this.tbRandomNumberCount.TabIndex = 1;
            // 
            // cbSaveRandomNumbers
            // 
            this.cbSaveRandomNumbers.AutoSize = true;
            this.cbSaveRandomNumbers.Location = new System.Drawing.Point(207, 86);
            this.cbSaveRandomNumbers.Name = "cbSaveRandomNumbers";
            this.cbSaveRandomNumbers.Size = new System.Drawing.Size(79, 17);
            this.cbSaveRandomNumbers.TabIndex = 2;
            this.cbSaveRandomNumbers.Text = "Save to file";
            this.cbSaveRandomNumbers.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(207, 109);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbInstructions
            // 
            this.tbInstructions.Location = new System.Drawing.Point(108, 12);
            this.tbInstructions.Multiline = true;
            this.tbInstructions.Name = "tbInstructions";
            this.tbInstructions.ReadOnly = true;
            this.tbInstructions.Size = new System.Drawing.Size(267, 40);
            this.tbInstructions.TabIndex = 5;
            this.tbInstructions.Text = "Please choose the count of random numbers to generate. Do not exceed 1000.";
            this.tbInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbNumbers
            // 
            this.rtbNumbers.Location = new System.Drawing.Point(13, 138);
            this.rtbNumbers.Name = "rtbNumbers";
            this.rtbNumbers.Size = new System.Drawing.Size(489, 261);
            this.rtbNumbers.TabIndex = 6;
            this.rtbNumbers.Text = "";
            // 
            // RandomNumberForm
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 411);
            this.Controls.Add(this.rtbNumbers);
            this.Controls.Add(this.tbInstructions);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cbSaveRandomNumbers);
            this.Controls.Add(this.tbRandomNumberCount);
            this.Controls.Add(this.lblRandomNumberCount);
            this.Name = "RandomNumberForm";
            this.Text = "Random Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandomNumberCount;
        private System.Windows.Forms.TextBox tbRandomNumberCount;
        private System.Windows.Forms.CheckBox cbSaveRandomNumbers;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbInstructions;
        private System.Windows.Forms.RichTextBox rtbNumbers;
    }
}