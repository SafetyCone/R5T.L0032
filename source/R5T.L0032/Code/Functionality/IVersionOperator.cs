using System;

using R5T.N0003;
using R5T.N0003.Extensions;

using R5T.T0132;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IVersionOperator : IFunctionalityMarker,
        F003.IVersionOperator
    {
        public IVersionString ToVersionString_ForProjectXml(Version version)
        {
            var versionStringValue = this.ToString_ForProjectXml(version);

            var output = versionStringValue.ToVersionString();
            return output;
        }
    }
}
