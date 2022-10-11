using App2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Storage
{
    internal class Repository
    {
        public string txtFilePath = @"/home/mororo/Repos/Mororo/C#/ClientRegistration/App2/client.txt";
        
        public void insertClient(Client client) 
        { 
            File.AppendAllText(txtFilePath, client + Environment.NewLine);
        }

        // public Client getClient()
        // {
        //  
        // }
    }
}
