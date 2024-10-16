using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmailService : INotification
    {

        public void Notify(string message)
        {
            System.Console.WriteLine($"New Email: {message}");
        }
    }
}