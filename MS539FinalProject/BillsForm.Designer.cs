
namespace MS539FinalProject
{
    partial class BillsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNotPaidBills = new System.Windows.Forms.RadioButton();
            this.rbPaidBills = new System.Windows.Forms.RadioButton();
            this.lblBillsTitle = new System.Windows.Forms.Label();
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.rbAllBills = new System.Windows.Forms.RadioButton();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.rbAllBills);
            this.panel1.Controls.Add(this.rbNotPaidBills);
            this.panel1.Controls.Add(this.rbPaidBills);
            this.panel1.Location = new System.Drawing.Point(161, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 84);
            this.panel1.TabIndex = 5;
            // 
            // rbNotPaidBills
            // 
            this.rbNotPaidBills.AutoSize = true;
            this.rbNotPaidBills.Location = new System.Drawing.Point(118, 35);
            this.rbNotPaidBills.Name = "rbNotPaidBills";
            this.rbNotPaidBills.Size = new System.Drawing.Size(66, 17);
            this.rbNotPaidBills.TabIndex = 1;
            this.rbNotPaidBills.Text = "Not Paid";
            this.rbNotPaidBills.UseVisualStyleBackColor = true;
            this.rbNotPaidBills.CheckedChanged += new System.EventHandler(this.rbNotPaidBills_CheckedChanged);
            // 
            // rbPaidBills
            // 
            this.rbPaidBills.AutoSize = true;
            this.rbPaidBills.Location = new System.Drawing.Point(118, 12);
            this.rbPaidBills.Name = "rbPaidBills";
            this.rbPaidBills.Size = new System.Drawing.Size(46, 17);
            this.rbPaidBills.TabIndex = 0;
            this.rbPaidBills.Text = "Paid";
            this.rbPaidBills.UseVisualStyleBackColor = true;
            this.rbPaidBills.CheckedChanged += new System.EventHandler(this.rbPaidBills_CheckedChanged);
            // 
            // lblBillsTitle
            // 
            this.lblBillsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBillsTitle.AutoSize = true;
            this.lblBillsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillsTitle.Location = new System.Drawing.Point(258, 0);
            this.lblBillsTitle.Name = "lblBillsTitle";
            this.lblBillsTitle.Size = new System.Drawing.Size(110, 55);
            this.lblBillsTitle.TabIndex = 4;
            this.lblBillsTitle.Text = "Bills";
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.AllowUserToAddRows = false;
            this.dataGridViewBills.AllowUserToDeleteRows = false;
            this.dataGridViewBills.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewBills.AutoGenerateColumns = false;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.personIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn});
            this.dataGridViewBills.DataSource = this.billBindingSource;
            this.dataGridViewBills.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.ReadOnly = true;
            this.dataGridViewBills.RowHeadersVisible = false;
            this.dataGridViewBills.Size = new System.Drawing.Size(605, 246);
            this.dataGridViewBills.TabIndex = 3;
            // 
            // rbAllBills
            // 
            this.rbAllBills.AutoSize = true;
            this.rbAllBills.Checked = true;
            this.rbAllBills.Location = new System.Drawing.Point(118, 58);
            this.rbAllBills.Name = "rbAllBills";
            this.rbAllBills.Size = new System.Drawing.Size(36, 17);
            this.rbAllBills.TabIndex = 2;
            this.rbAllBills.TabStop = true;
            this.rbAllBills.Text = "All";
            this.rbAllBills.UseVisualStyleBackColor = true;
            this.rbAllBills.CheckedChanged += new System.EventHandler(this.rbAllBills_CheckedChanged);
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "BillId";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDueDataGridViewTextBoxColumn
            // 
            this.amountDueDataGridViewTextBoxColumn.DataPropertyName = "AmountDue";
            this.amountDueDataGridViewTextBoxColumn.HeaderText = "AmountDue";
            this.amountDueDataGridViewTextBoxColumn.Name = "amountDueDataGridViewTextBoxColumn";
            this.amountDueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            this.paidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(MS539FinalProject.Models.Bill);
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBillsTitle);
            this.Controls.Add(this.dataGridViewBills);
            this.Name = "BillsForm";
            this.Text = "BillsForm";
            this.Load += new System.EventHandler(this.BillsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNotPaidBills;
        private System.Windows.Forms.RadioButton rbPaidBills;
        private System.Windows.Forms.Label lblBillsTitle;
        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.RadioButton rbAllBills;
    }
}