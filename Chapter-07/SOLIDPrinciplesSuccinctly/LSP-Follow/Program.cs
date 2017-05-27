using System;
using System.Collections.Generic;
using System.Linq;

namespace LSP_Follow
{
    //Code updated as requested by Gkavranis George
    internal class Program
    {
        private static void Main(string[] args)
        {
            var validators = LoadAllValidationRules();
            Console.WriteLine("Total validation rules {0} are loaded.", validators.Count());

            var validationChecks = new List<IValidatorCheck>
            {
                new TypeValidator(),
                new IPValidator(),
                new DateValidator(),
                //new DynamicValidator()
            };
            Console.WriteLine("Validation Checks are {0}",
                IsValidationRulePassed(validationChecks) ? "passing" : "failing");
        }


        private static IEnumerable<IValidatorLoader> LoadAllValidationRules()
        {
            var validators = new List<IValidatorLoader>
            {
                new TypeValidator(),
                new IPValidator(),
                new DateValidator(),
                //new DynamicValidator()
            };
            validators.ForEach(v => v.Load());
            return validators;
        }


        //Use this where we need certain checks for Validators
        private static bool IsValidationRulePassed(IEnumerable<IValidatorCheck> validatorChecks)
        {
            foreach (var v in validatorChecks)
            {
                if (!v.IsValid()) return false;
            }
            return true;
            
        }
    }
}