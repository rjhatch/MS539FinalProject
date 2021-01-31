using MS539FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539FinalProject
{
    /// <summary>
    /// UserBase provides the base class for all users.
    /// </summary>
    class UserBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Person MyProperty { get; set; }
    }
}
