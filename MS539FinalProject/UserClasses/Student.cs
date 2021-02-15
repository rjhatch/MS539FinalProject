using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject
{
    /// <summary>
    /// This student class extends UserBase.
    /// </summary>
    class Student : UserBase
    {
        public Student(Person person) : base(person)
        {

        }

        public Bill[] Bills { get; set; }
    }
}
