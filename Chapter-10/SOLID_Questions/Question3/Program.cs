using System;
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            var premisesClient = new OnPremisesClient();
            var cloudClient = new CloudClient();
            ProcessNotifications(new List<Notify>
            {
                premisesClient,
                cloudClient
            }
                );

            Console.ReadLine();
        }

        private static void ProcessNotifications(List<Notify> list)
        {
            HandleItems(list);
        }

        static void HandleItems(IEnumerable<Notify> notifications)
        {
            foreach (var notification in notifications)
            {
                if (notification is CloudClient)
                {
                    var cloudClient = notification as CloudClient;
                    cloudClient.IsOnPremisesToo = true;
                }

                notification.NotifyClient();
            }
        }
    }

    public abstract class Notify
    {
        public abstract void NotifyClient();
    }

    public class OnPremisesClient : Notify
    {
        public override void NotifyClient()
        {
            Console.WriteLine("You're getting these notifications because you opted....");
        }
    }

    public class CloudClient : Notify
    {
        public override void NotifyClient()
        {
            Console.WriteLine("You're getting these notifications because you opted....");
            if (IsOnPremisesToo)
                NotifyClientAsOnPremisesClient();
        }

        public void NotifyClientAsOnPremisesClient()
        {
            Console.WriteLine("Awesome! You are also using On premises services...");
        }

        public bool IsOnPremisesToo { get; set; }
    }
}