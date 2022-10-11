using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Service
{
    public class ClientService
    {
        public string upperName(string firstName)
        {
            return char.ToUpper(firstName[0]) + firstName.Substring(1);
            
        }

        public bool isCpfValid(long clientCpf)
        {
            var digitQty = clientCpf.ToString().Length;
            if (digitQty != 11)
            {
                return false;
            }
            return true;
        
        

        }



        public bool isAgeValid(int clientAge)
        {
            if (clientAge > 100)
            {
                return false;
            } 
            return true;
         } 
           
    }
}
