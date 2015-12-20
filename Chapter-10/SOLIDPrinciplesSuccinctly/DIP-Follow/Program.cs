using System;

namespace DIP_Follow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Satrt writing validation results.");

            IDataValidator dataValidator = new DataValidator(new SchemaValidatorWriter());

            Console.ReadLine();
        }
    }
}
