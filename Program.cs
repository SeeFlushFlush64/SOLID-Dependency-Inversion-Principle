using System;
namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            INotification _email = new EmailService();
            NotificationService _enotification = new NotificationService(_email);
            _enotification.Notify("Hello, from Email");
            INotification _push = new PushNotificationService();
            NotificationService _pnotification = new NotificationService(_push);
            _pnotification.Notify("Hello, from Push notification");
        }
    }
}