using System;

namespace ISP_Follow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old clients, who do not require new method");

            IValidator validator = new Validator();
            var isvalid = validator.Isvalid();

            NotifyValidationStuff(isvalid);

            IvalidatorLoader validatorLoader = new SpecialValidator();
            NotifyValidationStuff(validatorLoader.Isvalid());

            //this is for example only, in real time one should have some business logic when to load validators
            validatorLoader.Load();
            Console.WriteLine("New client can get the taste of Load() method as well");

            Console.ReadLine();

        }

        private static void NotifyValidationStuff(bool isvalid)
        {
            Console.WriteLine("Validations are {0}.", isvalid ? "passing" : "failing");
        }
    }
}
