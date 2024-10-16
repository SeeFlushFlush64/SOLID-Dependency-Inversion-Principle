using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class NotificationService
    {
        private readonly INotification _notification;
        public NotificationService(INotification notification)
        {
            _notification = notification;
        }

        public void Notify(string message)
        {
            _notification.Notify(message);
        }
    }
}