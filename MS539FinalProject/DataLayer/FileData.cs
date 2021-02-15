using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539FinalProject.DataLayer
{
    class FileData : iData
    {
        private Person[] people = new Person[0];
        private Bill[] bills = new Bill[0];

        public Person[] GetPeople { get { return people; } }
        public Bill[] GetBills { get { return bills; } }

        public FileData()
        {
            //Get the information from the files when the object is instantiated.
            try
            {
                PeopleStringToArray(File.ReadAllText("PeopleFile.txt"));
                BillStringToArray(File.ReadAllText("BillsFile.txt"));
            }
            catch
            {
                MessageBox.Show("Error reading from file(s)");
            }


        }

        private void PeopleStringToArray(string peopleString)
        {
            List<Person> peopleList = new List<Person>();
            int recordCount = 0;

            //find how many records there are by counting newlines
            foreach (var c in peopleString)
            {
                if (c.Equals('\n'))
                {
                    recordCount++;
                }
            }

            //replace the newline characters with a comma
            peopleString = peopleString.Replace('\n', ',');

            //split the string into an array
            string[] peopleStringSplit = peopleString.Split(',');

            //start this loop at 1 to skip the headers
            for (int i = 1; i < recordCount; i++)
            {
                //If there are formatting errors in the file, an exception will be thrown.
                try
                {
                    Person person = new Person
                    {
                        PersonId = peopleStringSplit[(i * 6) + 0],
                        Username = peopleStringSplit[(i * 6) + 1],
                        Password = peopleStringSplit[(i * 6) + 2],
                        FirstName = peopleStringSplit[(i * 6) + 3],
                        LastName = peopleStringSplit[(i * 6) + 4],
                        Role = peopleStringSplit[(i * 6) + 5]
                    };

                    peopleList.Add(person);
                }
                catch 
                {
                    MessageBox.Show("Error: There are formatting errors in the PEOPLE file.");
                    break;
                }

            }

            people = peopleList.ToArray();
        }

        public void BillStringToArray(string billString)
        {
            List<Bill> billList = new List<Bill>();
            int recordCount = 0;

            //find how many records there are by counting newlines
            foreach (var c in billString)
            {
                if (c.Equals('\n'))
                {
                    recordCount++;
                }
            }

            //replace the newline characters with a comma
            billString = billString.Replace('\n', ',');

            //split the string into an array
            string[] billStringSplit = billString.Split(',');

            //start this loop at 1 to skip the headers
            for (int i = 1; i < recordCount; i++)
            {
                //If there are formatting errors in the file, an exception will be thrown.
                try
                {
                    Bill bill = new Bill
                    {
                        BillId = billStringSplit[(i * 6) + 0],
                        PersonId = billStringSplit[(i * 6) + 1],
                        Date = DateTime.Parse(billStringSplit[(i * 6) + 2]),
                        Description = billStringSplit[(i * 6) + 3],
                        AmountDue = float.Parse(billStringSplit[(i * 6) + 4]),
                        //just check the first character in the string
                        Paid = billStringSplit[(i * 6) + 5][0] == 'Y' ? true : false
                    };

                    billList.Add(bill);
                }
                catch
                {
                    MessageBox.Show("Error: There are formatting errors in the BILL file.");
                    break;
                }

            }

            bills = billList.ToArray();
        }
    }
}
