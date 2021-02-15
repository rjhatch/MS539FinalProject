using MS539FinalProject.DataLayer;
using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject.BusinessLayer
{
    /// <summary>
    /// This class is the main hub for business logic in this program.
    /// </summary>
    public class ProgramManager
    {
        public bool LoggedIn { get; private set; }

        public Person person { get; private set; }

        private DataAccessor data = new DataAccessor(true);

        /// <summary>
        /// Checks the strings to validate them.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LogIn(string username, string password)
        {
            person = data.GetPersonByUsername(username);

            if (person == null)
                return false;

            if (person.Password == password)
            {
                LoggedIn = true;
                return true;
            }

            LoggedIn = false;
            return false;
        }

        /// <summary>
        /// Log the current user out.
        /// </summary>
        public void Logout()
        {
            LoggedIn = false;
        }

        public Bill[] GetBills()
        {
            return data.GetBills();
        }

        public Bill[] GetBillsByPerson(string personId)
        {
            return data.GetBillsByPerson(personId);
        }
    }
}
