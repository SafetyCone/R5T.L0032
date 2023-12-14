using System;

using R5T.T0132;


namespace R5T.L0032.F003
{
    [FunctionalityMarker]
    public partial interface IVersionOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0066.IVersionOperator _Base => L0066.VersionOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="L0066.IVersionOperator.ToString_Major_Minor_Build(Version)"/>
        public string ToString_ForProjectXml(Version version)
        {
            var output = _Base.ToString_Major_Minor_Build(version);
            return output;
        }
    }
}
