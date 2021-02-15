using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject.DataLayer
{
    class DataAccessor
    {
        public bool UsingFileData { get; }
        private FileData fileData = new FileData();
        private DatabaseData databaseData = new DatabaseData();

        /// <summary>
        /// Pass true to use File Data, false to Use a database.
        /// </summary>
        /// <param name="fileDataSource"></param>
        public DataAccessor(bool fileDataSource)
        {
            UsingFileData = fileDataSource;
        }

        public Person[] GetPeople()
        {
            if (UsingFileData)
            {
                return fileData.GetPeople;
            }
            else
            {
                return new Person[0];
            }
        }

        public Person GetPersonByUsername(string username)
        {
            Person[] people;

            if (UsingFileData)
            {
                people = fileData.GetPeople;
            }
            else
            {
                return new Person();
            }

            //returns the person based on username.
            return (Person)people.Where(p => p.Username == username).FirstOrDefault();
        }

        public Bill[] GetBills()
        {
            if (UsingFileData)
            {
                return fileData.GetBills;
            }
            else
            {
                return new Bill[0];
            }
        }

        public Bill[] GetBillsByPerson(string personId)
        {
            Bill[] bills;

            if (UsingFileData)
            {
                bills = fileData.GetBills;
            }
            else
            {
                bills = new Bill[0];
            }

            return (Bill[])bills.Where(b => b.PersonId == personId).ToArray();
        }
    }
}
