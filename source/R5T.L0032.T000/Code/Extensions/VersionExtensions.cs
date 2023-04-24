using System;


namespace R5T.L0032.T000.Extensions
{
    public static class VersionExtensions
    {
        public static IPackageVersion ToPackageVersion(this Version version)
        {
            return Instances.VersionOperator.ToPackageVersion(version);
        }
    }
}
