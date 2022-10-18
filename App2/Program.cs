using System;
using App2.Model;
using App2.Service;
using App2.Storage;

namespace App2;

class Program
{
    static void Main(string[] args)
    {
        var newService = new ClientService();


        var firstAddress = new Address(903428, "Leblon", 324, "Ape");
        var user1 = new Client(276, "Ariane", 29, 012345678911, firstAddress);

        newService.isUservalid(user1);

    }
}