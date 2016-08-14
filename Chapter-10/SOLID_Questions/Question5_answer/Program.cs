using System;
using System.Collections.Generic;

namespace Question5_answer
{
    class Program
    {
        static void Main(string[] args)
        {
            //CientA
            IClient clientA = new ClientA();
            var subscriptionsForA = clientA.Subscriptions();
            Console.WriteLine("ClientA subscribed for {0} providers.",subscriptionsForA.Item1);
            var notifyToClientA = new Notification(subscriptionsForA.Item2);
            notifyToClientA.SendAll();

            //ClientB
            IClient clientB = new ClientB();
            var subscriptionsForB = clientB.Subscriptions();
            Console.WriteLine("ClientB subscribed for {0} providers.", subscriptionsForB.Item1);
            var notifyToClientB = new Notification(subscriptionsForB.Item2);
            notifyToClientB.SendAll();

            //ClientC
            IClient clientC = new ClientC();
            var subscriptionsForC = clientC.Subscriptions();
            Console.WriteLine("ClientC subscribed for {0} providers.", subscriptionsForC.Item1);
            var notifyToClientC = new Notification(subscriptionsForC.Item2);
            notifyToClientC.SendAll();

            Console.ReadLine();
        }
    }

    public interface IClient
    {
        //Used tuple just to keep it simple
        //You can use, whatever you want (key,value) etc.
        Tuple<int, IEnumerable<IProcess>> Subscriptions();
    }

    public class ClientA : IClient
    {
        public Tuple<int, IEnumerable<IProcess>> Subscriptions()
        {
            //Get list of subscribed providers or notifier whatever you called it
            //Best bet to get this list is database
            //ClientA - subscribed for only one provider
            return new Tuple<int, IEnumerable<IProcess>>(1, new List<IProcess> {new OnPremiseProvider()});
        }
    }

    public class ClientB : IClient
    {
        public Tuple<int, IEnumerable<IProcess>> Subscriptions()
        {
            //ClientB - subscribed for two providers
            return new Tuple<int, IEnumerable<IProcess>>(2,
                new List<IProcess> {new OnPremiseProvider(), new CloudNotifier()});
        }
    }

    public class ClientC : IClient
    {
        public Tuple<int, IEnumerable<IProcess>> Subscriptions()
        {
            //ClientB - subscribed for three providers
            return new Tuple<int, IEnumerable<IProcess>>(3,
                new List<IProcess> {new OnPremiseProvider(), new CloudNotifier(), new GalaxyNotifier()});
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