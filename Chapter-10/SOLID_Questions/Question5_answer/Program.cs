using System;
using System.Collections.Generic;

namespace Question5_answer
{
    class Program
    {
        static void Main(string[] args)
        {
            var notifications = (new List<INotify>
            {
                new OnPremiseNotifier(),
                new CloudNotifier()
            });
            var notification = new Notification(notifications);
            notification.SendAll();

            Console.ReadLine();
        }
    }

    public class Notification
    {
        private readonly List<INotify> _providerList;

        public Notification(List<INotify> providerList)
        {
            _providerList = providerList;
        }

        public void SendAll()
        {
            foreach (var notificationProvider in _providerList)
            {
                notificationProvider.Notify();
            }
        }
    }

    public interface INotify
    {
        void Notify();
    }

    public class OnPremiseNotifier : INotify
    {
        public void Notify()
        {
            Console.WriteLine("You're getting these notifications because you opted for OnPremise Notifications....");
        }
    }

    public class CloudNotifier : INotify
    {
        public void Notify()
        {
            Console.WriteLine("You're getting these notifications because you opted for Cloud Notifications....");
        }
    }
}