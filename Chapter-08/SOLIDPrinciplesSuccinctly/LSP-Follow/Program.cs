using System;
using System.Collections.Generic;
using System.Linq;

namespace LSP_Follow
{
    class Program
    {
        static void Main(string[] args)
        {
            var validators = LoadAllValidationRules();

            Console.WriteLine("Total validation rules {0} are loaded.", validators.Count());

        }

        private static IEnumerable<IValidatorLoader> LoadAllValidationRules()
        {
            var validators = new List<IValidatorLoader> {
                                                    new TypeValidator(),
                                                    new IPValidator(),
                                                    new DateValidator(),
                                                    new DynamicValidator()
                                                   };
            validators.ForEach(v => v.Load());
            return validators;
        }

        private static bool IsValidationRulePassed(IEnumerable<IValidatorCheck> validators)
        {
            bool isValid = false;
            foreach (var v in validators)
            {
                isValid = v.IsValid();

                if (!isValid)
                    return false;

            }
            return false; ;
        }
    }
}
