using System;
using System.Collections.Generic;

namespace LSP_Violation
{
    class Program
    {
        static void Main(string[] args)
        {
            var validators = LoadAllValidationRules();

            Console.WriteLine("RuleValidations are {0}", IsValidationRulePassed(validators) ? "passing" : "failing");
        }

        private static IEnumerable<IValidator> LoadAllValidationRules()
        {
            var validators = new List<IValidator> {
                                                    new TypeValidator(),
                                                    new IPValidator(),
                                                    new DateValidator(),
                                                    new DynamicValidator()
                                                   };
            validators.ForEach(v => v.Load());
            return validators;
        }

        private static bool IsValidationRulePassed(IEnumerable<IValidator> validators)
        {
            bool isValid = false;
            foreach (var v in validators)
            {
                if (v is DynamicValidator)
                    continue;

                isValid = v.IsValid();

                if (!isValid)
                    return false;

            }
            return false; ;
        }
    }
}
