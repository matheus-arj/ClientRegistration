using App2.Model;
using App2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Storage
{
    public class Repository
    {
        public string txtFilePath = @"C:\Users\Diogo\Desktop\ClientRegistration\App2\client.txt";
        public void insertClient(Client client)
        {
            File.AppendAllText(txtFilePath, client + Environment.NewLine);
        }

        public string getClient()
        {
            string Client = File.ReadAllText(txtFilePath);
            return Client;
        }
    }
}
