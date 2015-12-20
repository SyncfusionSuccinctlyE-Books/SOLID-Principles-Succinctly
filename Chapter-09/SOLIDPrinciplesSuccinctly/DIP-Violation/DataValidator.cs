using System;

namespace DIP_Violation
{
    public class DataValidator : IDataValidator
    {
        private IValidatorWriter writer;

        public void Validator(ValidatorWriter validatorWriter)
        {
            //write stuff to validate data
            string validationResults = ValidateData();

            //Write validationResults
            WriteValidationResults(validatorWriter, validationResults);
        }

        private void WriteValidationResults(ValidatorWriter validatorWriter, string validationResults)
        {
            if (validatorWriter == ValidatorWriter.FileValidatorWriter)
                writer = new FileValidatorWriter();
            else if (validatorWriter == ValidatorWriter.TypeValidatorWriter)
                writer = new TypeValidatorWriter();
            else if (validatorWriter == ValidatorWriter.DataValidatorWriter)
                writer = new DataValidatorWriter();
            else if (validatorWriter == ValidatorWriter.IPValidatorWriter)
                writer = new IPValidatorWriter();
            else if (validatorWriter == ValidatorWriter.SchemaValidatorWriter)
                writer = new SchemaValidatorWriter();
            else if (validatorWriter == ValidatorWriter.CodeValidatorWriter)
                writer = new CodeValidatorWriter();
            else
                throw new ArgumentException("No matched validator found.", validatorWriter.ToString());
            writer.Write(validationResults);
        }

        private string ValidateData()
        {
            throw new NotImplementedException();
        }
    }
}
