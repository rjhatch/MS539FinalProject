using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject.Models
{
    class Bill
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public float AmountDue { get; set; }
        public bool Paid { get; set; }

    }
}
