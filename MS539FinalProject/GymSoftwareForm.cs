/* Richie Hatch
 * Due date: 1/31/2021
 * Description: The proposal for the final project is gym management software. All classes are instructor 
 *      lead at the facility and there is limited space available. There are three levels of access: student, 
 *      employee, and employer or administrator. All information will be served from data storage. This will likely 
 *      be text files. However, given there is adequate time, a database would be preferred. Most of the information 
 *      is shared and will reduce the amount of work required and the need to create redundant views.
 * 
 * 
 * 
 * 
 * Estimate for the completed project: 15 hours.
 * Estimate to add DB support: 6 hours.
 * 
 * Estimate for deliverables due on 1/31/2021 - 2 hours
 * 
 * 1/25/2021 - .5 hours
 * 1/27/2021 - .25 hours
 * 1/28/2021 - .25 hours
 */




using MS539FinalProject.Deliverables;
using MS539FinalProject.Deliverables.Forms;
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
    public partial class GymSoftwareForm : Form
    {
        public GymSoftwareForm()
        {
            InitializeComponent();
        }

        private void GymSoftwareForm_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new LoginForm();

            login.MdiParent = this;

            login.Show();

            if (login.DialogResult == DialogResult.OK)
            {
                Console.WriteLine("login result ok");
            }
            else
            {
                Console.WriteLine("login result cancel");
            }
        }

        private void randomNumberLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumbers randomNumbers = new RandomNumbers(100);

            MessageBox.Show(randomNumbers.NumberList);
        }

        private void RandomNumberGenerator(object sender, EventArgs e)
        {
            RandomNumberForm randomNumberForm = new RandomNumberForm();
            randomNumberForm.MdiParent = this;

            randomNumberForm.Show();
        }
    }
}
