using System;


namespace R5T.L0032.Z000
{
    public class CustomProjectElementNames : ICustomProjectElementNames
    {
        #region Infrastructure

        public static ICustomProjectElementNames Instance { get; } = new CustomProjectElementNames();


        private CustomProjectElementNames()
        {
        }

        #endregion
    }
}
