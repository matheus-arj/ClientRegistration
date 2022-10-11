using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Service
{
    public class ClientService
    {
     //   public bool isNameValid(string clientName)
     //   {
            
     //   }

        public bool isCpfValid(long clientCpf)
        {
            if (clientCpf < 11)
            {
                return "CPF inválido";
            } else if (clientCpf > 11) 
            {
                return "CPF inválido";

            } else (clientCpf == 11);
                    return;
                    
        }

        //public bool isAgeValid(int clientAge)
      //  {

      //  }
    }
}
