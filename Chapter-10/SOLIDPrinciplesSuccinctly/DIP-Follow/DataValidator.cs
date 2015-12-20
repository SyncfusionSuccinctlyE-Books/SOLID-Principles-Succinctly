using System;

namespace DIP_Follow
{
    public class DataValidator : IDataValidator
    {
        private readonly IValidatorWriter _writer;

        public DataValidator(IValidatorWriter writer)
        {
            _writer = writer;
        }

        public void Validator(ValidatorWriter validatorWriter)
        {
            //write stuff to validate data
            string validationResults = ValidateData();

            //Write validationResults
            _writer.Write(validationResults);
        }

        private string ValidateData()
        {
            throw new NotImplementedException();
        }
    }
}
