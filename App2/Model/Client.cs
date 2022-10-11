using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Model
{
    public class Client
    {
        int Id;
        string FirstName;
        int Age;
        Address Address;

        public Client (int id, string firstName, int age, Address address)
        {
            Id = id;
            FirstName = firstName;
            Age = age;
            Address = address;
        }
    }

}
