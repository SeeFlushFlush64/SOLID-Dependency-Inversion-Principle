using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class PushNotificationService : INotification
    {
        public void Notify(string message)
        {
            System.Console.WriteLine($"New Push notification: {message}");
        }
    }
}