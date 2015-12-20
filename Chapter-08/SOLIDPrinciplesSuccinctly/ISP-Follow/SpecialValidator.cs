using System;

namespace ISP_Follow
{
    public class SpecialValidator : IValidator, IvalidatorLoader
    {
        public bool Isvalid()
        {
            //why should I do new stuffs, I have this method already in place
            Validator validator = new Validator();
            return validator.Isvalid();
        }

        public void Load()
        {
            //Perform few good stuff here to load special validator
        }
    }
}
