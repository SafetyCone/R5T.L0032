using System;

using R5T.T0132;


namespace R5T.L0032.T000
{
    [FunctionalityMarker]
    public partial interface IVersionOperator : IFunctionalityMarker
    {
        public IPackageVersion ToPackageVersion(Version version)
        {
            var output = new PackageVersion(version);
            return output;
        }
    }
}
