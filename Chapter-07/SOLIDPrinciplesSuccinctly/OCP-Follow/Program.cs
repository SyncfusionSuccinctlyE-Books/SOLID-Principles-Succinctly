using System;
using System.Collections.Generic;
using System.Linq;

namespace OCP_Follow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Only for demonstration purposes
            var sourceServerData = new List<SourceServerData>();
            var serverData = new List<ServerData>();
            foreach (var data in serverData)
            {
                var sourceData = sourceServerData.FirstOrDefault(s => s.RecordIdentifier == data.RecordIdentifier);

                var isValid = IsValid(data, sourceData);
                Console.WriteLine("Record with Id {0} is {1}", data.RecordIdentifier, isValid);
            }

            Console.ReadLine();

        }

        private static bool IsValid(ServerData data, SourceServerData sourceData)
        {
            List<IValidator> validators = AddValidatorsToValidate();
            IValidateData validateData = new ValidateData(validators);
            return validateData.Validate(data, sourceData);
        }

        private static List<IValidator> AddValidatorsToValidate()
        {
            return new List<IValidator>
            {
                new IPValidator(),
                new TypeValidator()
            };
        }
    }
}
