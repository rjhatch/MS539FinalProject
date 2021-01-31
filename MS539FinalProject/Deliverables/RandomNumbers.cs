using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject.Deliverables
{
    /// <summary>
    /// Generates a StringBuilder with random numbers.
    /// </summary>
    class RandomNumbers
    {
        private StringBuilder numberList = new StringBuilder();

        public String NumberList { get {
                return GetNumberList();
            } }

        /// <summary>
        /// Count indicates how many numbers should be generated.
        /// </summary>
        /// <param name="count"></param>
        public RandomNumbers(int count)
        {
            numberList = BuildTheString(GenerateNumbers(count));
        }

        /// <summary>
        /// Returns the randomly generated numbers as a string.
        /// </summary>
        /// <returns></returns>
        private string GetNumberList()
        {
            return numberList.ToString();
        }

        /// <summary>
        /// Generates the random numbers based on the count.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts the list of integers to a formatted StringBuilder. 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
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
