﻿using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject.DataLayer
{
    class DatabaseData : iData
    {
        public Person[] GetPeople => throw new NotImplementedException();

        public Bill[] GetBills => throw new NotImplementedException();
    }
}
