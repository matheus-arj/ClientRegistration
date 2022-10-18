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
        public int Id;
        public string FirstName;
        public int Age;
        public long ClientCpf;
        public Address Address;

        //Construtor:
        public Client (int id, string firstName, int age, long clientCpf, Address address)
        {
            Id = id;
            FirstName = firstName;
            Age = age;
            ClientCpf = clientCpf;
            Address = address;              
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(FirstName)}: {FirstName}, {nameof(Age)}: {Age}, {nameof(ClientCpf)}: {ClientCpf}, {nameof(Address)}: {Address}";
        }
    }

}
