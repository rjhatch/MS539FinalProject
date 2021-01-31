using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject
{
    class Student : UserBase
    {
        public Bill[] Bills { get; set; }
    }
}
