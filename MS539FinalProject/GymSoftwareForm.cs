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
 * Estimate for deliverables due on 1/31/2021 - 2 hours / 1 actual
 * 
 * 1/25/2021 - .5 hours
 * 1/27/2021 - .25 hours
 * 1/28/2021 - .25 hours
 * 
 * Estimate for deliverables due on 2/7/2021 - 2 hours / 3 actual
 * 2/1/2021 - .5 hours
 * 2/2/2021 - 2 hours
 * 2/3/2021 - .5 hours
 * 
 * Estimate for delivarables due on 2/14/2021 - 5 hours / 4.5 actual
 * 2/11/2021 - 3 hours
 * 2/13/2021 - .5 hours
 * 2/14/2021 - 1 hour
 * 
 * The reason I was under by a half-hour this week is because I did not have to google as much. 
 * I was able to understand the direction I was going and make the program get there. Trying to estimate 
 * project times in hours is hard for me. I like to look at how many days something will take me rather than 
 * the number of hours because I must look up a ton of information. I do appreciate thinking about it though 
 * and it makes sense why that is the requirement.
 */

using MS539FinalProject.BusinessLayer;
using MS539FinalProject.Deliverables;
using MS539FinalProject.Deliverables.Forms;
using System;
using System.Windows.Forms;

namespace MS539FinalProject
{
    public partial class GymSoftwareForm : Form
    {
        public ProgramManager programManager;

        public GymSoftwareForm()
        {
            InitializeComponent();
        }

        private void GymSoftwareForm_Load(object sender, EventArgs e)
        {
            programManager = new ProgramManager();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm(this);

            loginForm.MdiParent = this;

            loginForm.Show();
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

        /// <summary>
        /// Updates the Gui based on the programManager.LoggedIn variable.
        /// </summary>
        public void UpdateGUI()
        {
            if (programManager.LoggedIn)
            {
                //hide the login tool strip menu item
                this.loginToolStripMenuItem.Enabled = false;
                this.loginToolStripMenuItem.Visible = false;

                //show the logout tool strip menu item
                this.logoutToolStripMenuItem.Enabled = true;
                this.logoutToolStripMenuItem.Visible = true;

                //show the bills menu item
                this.billsToolStripMenuItem.Enabled = true;
                this.billsToolStripMenuItem.Visible = true;

                //show the welcome message on the right side
                lblWelcomeText.Text = $"Hello, {programManager.person.FirstName}!";
                lblWelcomeText.Visible = true;
            }
            else
            {
                //show the login tool strip menu item
                this.loginToolStripMenuItem.Enabled = true;
                this.loginToolStripMenuItem.Visible = true;

                //hide the logout tool strip menu item
                this.logoutToolStripMenuItem.Enabled = false;
                this.logoutToolStripMenuItem.Visible = false;

                //hide the bills menu item
                this.billsToolStripMenuItem.Enabled = false;
                this.billsToolStripMenuItem.Visible = false;

                //hide the welcome message on the right side
                lblWelcomeText.Visible = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programManager.Logout();

            foreach (Form form in this.MdiChildren)
            {
                    form.Close();
            }

            UpdateGUI();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form billsForm = new BillsForm(programManager.GetBillsByPerson(programManager.person.PersonId));

            billsForm.MdiParent = this;

            billsForm.Show();
        }
    }
}
