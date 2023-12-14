using System;

using R5T.N0003;
using R5T.N0003.Extensions;

using R5T.T0131;


namespace R5T.L0032.Z002
{
    [ValuesMarker]
    public partial interface ICompanyNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.ICompanyNames _Platform => Platform.CompanyNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Platform.ICompanyNames.Rivet"/>
        public ICompanyName Rivet => _Platform.Rivet.ToCompanyName();
    }
}
