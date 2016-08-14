using System;
using System.Collections.Generic;

namespace Question3_answer
{
    class Program
    {
        static void Main(string[] args)
        {
            var notification = new Notification(new List<IProcess>
            {
                new CloudNotifier(),
                new OnPremiseProvider(),
                new GalaxyNotifier()
            });

            notification.SendAll();

            Console.ReadLine();
        }
    }

    public class Notification
    {
        private readonly IEnumerable<IProcess> _providerList;

        public Notification(IEnumerable<IProcess> providerList)
        {
            _providerList = providerList;
        }

        public void SendAll()
        {
            foreach (var notificationProvider in _providerList)
            {
                notificationProvider.Process();
            }
        }
    }

    public interface IProcess
    {
        void Process();
    }

    public class OnPremiseProvider : IProcess
    {
        public void Process()
        {
            //This should be used more than just a message or notification
            //Assuming there are few business rules for this particular provider
            //proces those rules and change code accordingly
            Console.WriteLine("You're getting these notifications because you opted for OnPremise Notifications....");
        }
    }

    public class CloudNotifier : IProcess
    {
        public void Process()
        {
            //This should be used more than just a message or notification
            //Assuming there are few business rules for this particular provider
            //proces those rules and change code accordingly
            Console.WriteLine("You're getting these notifications because you opted for Cloud Notifications....");
        }
    }

    public class GalaxyNotifier : IProcess
    {
        public void Process()
        {
            //This should be used more than just a message or notification
            //Assuming there are few business rules for this particular provider
            //proces those rules and change code accordingly
            Console.WriteLine("You're getting these notifications because you opted for Galaxy Notifications....");
        }
    }
}