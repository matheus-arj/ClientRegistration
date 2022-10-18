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
        public long Cep;
        public string Street;
        public int Number;
        public string Complement;

        //Construtor
        public Address(long cep, string street, int number, string complement)
        {
            Cep = cep;
            Street = street;
            Number = number;
            Complement = complement;
        }

        public override string ToString()
        {
            return $"{nameof(Cep)}: {Cep}, {nameof(Street)}: {Street}, {nameof(Number)}: {Number}, {nameof(Complement)}: {Complement}";
        }
    }
}
