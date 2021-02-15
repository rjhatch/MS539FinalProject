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
        public string Username { get; private set; }
        public string Password { get; private set; }
        public Person Person { get; private set; } = new Person();

        public UserBase(Person person)
        {
            Person = person;
            Username = Person.Username;
            Password = Person.Password;
        }
    }
}
