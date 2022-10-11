using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Model
{
    public class Address
    {
        //Atributos:
        long Cep;
        string Street;
        int Number;
        string Complement;

        //Construtor
        public Address(long cep, string street, int number, string complement)
        {
            Cep = cep;
            Street = street;
            Number = number;
            Complement = complement;
        }
    }
}
