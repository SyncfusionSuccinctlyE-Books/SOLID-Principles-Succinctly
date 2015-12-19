using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesSuccinctly
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
            var validators = new List<IValidator> { new TypeValidator(), new IPValidator(), new DateValidator() };
            validators.ForEach(v => v.Load());
            return validators;
        }

        private static bool IsValidationRulePassed(IEnumerable<IValidator> validators)
        {
            return validators.Where(v => v.IsValid()).Count() == validators.Count();
        }
    }
}
