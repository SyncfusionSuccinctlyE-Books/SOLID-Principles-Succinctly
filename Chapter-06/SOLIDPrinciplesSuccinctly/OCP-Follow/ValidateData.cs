using System.Collections.Generic;
using System.Linq;

namespace OCP_Follow
{
    public class ValidateData : IValidateData
    {
        private readonly IEnumerable<IValidator> _validators;
        public ValidateData(IEnumerable<IValidator> validators)
        {
            _validators = validators;
        }
        public bool Validate(ServerData data, SourceServerData sourceData)
        {
            return _validators.Any(validator => validator.IsValid(data, sourceData));
        }
    }
}
