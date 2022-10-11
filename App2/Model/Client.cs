using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Model
{
    public class Client
    {
        //Atributos:
        int Id;
        string FirstName;
        int Age;
        long ClientCpf;
        Address Address;

        //Construtor:
        public Client (int id, string firstName, int age, long clientCpf, Address address)
        {
            Id = id;
            FirstName = firstName;
            Age = age;
            ClientCpf = clientCpf;
            Address = address;              
        }
    }

}
