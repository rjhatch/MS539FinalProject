using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject.Deliverables
{
    class RandomNumbers
    {
        private StringBuilder numberList = new StringBuilder();

        public String NumberList { get {
                return GetNumberList();
            } }

        public RandomNumbers(int count)
        {
            numberList = BuildTheString(GenerateNumbers(count));
        }

        private string GetNumberList()
        {
            return numberList.ToString();
        }

        private List<int> GenerateNumbers(int count)
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(rand.Next(100));
            }

            return numbers;


        }

        private StringBuilder BuildTheString(List<int> list)
        {
            StringBuilder theString = new StringBuilder();

            theString.AppendLine("Number Count: " + list.Count.ToString());

            for (int i = 0; i < list.Count; i++)
            {
                theString.AppendLine(i + 1 + ". " + list[i].ToString());
            }

            return theString;
        }
    }
}
