using System;


namespace R5T.L0032.Z002
{
    public class CompanyNames : ICompanyNames
    {
        #region Infrastructure

        public static ICompanyNames Instance { get; } = new CompanyNames();


        private CompanyNames()
        {
        }

        #endregion
    }
}


namespace R5T.L0032.Z002.Platform
{
    public class CompanyNames : ICompanyNames
    {
        #region Infrastructure

        public static ICompanyNames Instance { get; } = new CompanyNames();


        private CompanyNames()
        {
        }

        #endregion
    }
}
