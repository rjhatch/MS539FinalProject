using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539FinalProject
{
    public partial class BillsForm : Form
    {
        private Bill[] bills;
        private Bill[] paidBills;
        private Bill[] unpaidBills;

        public BillsForm(Bill[] bills)
        {
            InitializeComponent();
            this.bills = bills;
            this.paidBills = (Bill[])bills.Where(b => b.Paid).ToArray();
            this.unpaidBills = (Bill[])bills.Where(b => !b.Paid).ToArray();
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewBills.DataSource = bills;
        }

        private void rbPaidBills_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridViewBills.DataSource = paidBills;
        }

        private void rbNotPaidBills_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridViewBills.DataSource = unpaidBills;
        }

        private void rbAllBills_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridViewBills.DataSource = bills;
        }
    }
}
