using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject.DataLayer
{
    interface iData
    {
        Person[] GetPeople { get;}
        Bill[] GetBills { get; }
    }
}
