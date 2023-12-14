using System;

using R5T.T0131;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.Z000
{
    /// <summary>
    /// For a list of Nuget supported license expressions (SPDX) see <inheritdoc cref="Y000.Documentation.Links.SPDXLicenseExpressions" path="/summary"/>.
    /// </summary>
    [ValuesMarker]
    public partial interface IPackageLicenseExpressions : IValuesMarker
    {
        public IPackageLicenseExpression MIT => "MIT".ToPackageLicenseExpression();
    }
}
