using System;

using R5T.F0120;
using R5T.F0120.Extensions;
using R5T.T0132;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IVersionOperator : IFunctionalityMarker
    {
        private static F0000.IVersionOperator Base => F0000.VersionOperator.Instance;


        /// <inheritdoc cref="F0000.IVersionOperator.ToString_Major_Minor_Build(Version)"/>
        public string ToString_ForProjectXml(Version version)
        {
            var output = Base.ToString_Major_Minor_Build(version);
            return output;
        }

        public IVersionString ToVersionString_ForProjectXml(Version version)
        {
            var versionStringValue = this.ToString_ForProjectXml(version);

            var output = versionStringValue.ToVersionString();
            return output;
        }
    }
}
