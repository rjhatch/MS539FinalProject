﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject.Models
{
    /// <summary>
    /// This model is used for bills. 
    /// </summary>
    public class Bill
    {
        public string BillId { get; set; }
        public string PersonId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public float AmountDue { get; set; }
        public bool Paid { get; set; }

    }
}
