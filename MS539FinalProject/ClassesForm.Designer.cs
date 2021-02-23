
namespace MS539FinalProject
{
    partial class ClassesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClassDte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClassesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAllClasses = new System.Windows.Forms.RadioButton();
            this.rbMyClasses = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassDte,
            this.ClassTime,
            this.ClassName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(304, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClassDte
            // 
            this.ClassDte.HeaderText = "Date";
            this.ClassDte.Name = "ClassDte";
            this.ClassDte.ReadOnly = true;
            // 
            // ClassTime
            // 
            this.ClassTime.HeaderText = "Time";
            this.ClassTime.Name = "ClassTime";
            this.ClassTime.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Name";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // lblClassesTitle
            // 
            this.lblClassesTitle.AutoSize = true;
            this.lblClassesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassesTitle.Location = new System.Drawing.Point(66, 9);
            this.lblClassesTitle.Name = "lblClassesTitle";
            this.lblClassesTitle.Size = new System.Drawing.Size(195, 55);
            this.lblClassesTitle.TabIndex = 1;
            this.lblClassesTitle.Text = "Classes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAllClasses);
            this.panel1.Controls.Add(this.rbMyClasses);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 55);
            this.panel1.TabIndex = 2;
            // 
            // rbAllClasses
            // 
            this.rbAllClasses.AutoSize = true;
            this.rbAllClasses.Location = new System.Drawing.Point(118, 35);
            this.rbAllClasses.Name = "rbAllClasses";
            this.rbAllClasses.Size = new System.Drawing.Size(75, 17);
            this.rbAllClasses.TabIndex = 1;
            this.rbAllClasses.TabStop = true;
            this.rbAllClasses.Text = "All Classes";
            this.rbAllClasses.UseVisualStyleBackColor = true;
            // 
            // rbMyClasses
            // 
            this.rbMyClasses.AutoSize = true;
            this.rbMyClasses.Location = new System.Drawing.Point(118, 12);
            this.rbMyClasses.Name = "rbMyClasses";
            this.rbMyClasses.Size = new System.Drawing.Size(78, 17);
            this.rbMyClasses.TabIndex = 0;
            this.rbMyClasses.TabStop = true;
            this.rbMyClasses.Text = "My Classes";
            this.rbMyClasses.UseVisualStyleBackColor = true;
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblClassesTitle);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassesForm";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.ClassesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassDte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.Label lblClassesTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAllClasses;
        private System.Windows.Forms.RadioButton rbMyClasses;
    }
}