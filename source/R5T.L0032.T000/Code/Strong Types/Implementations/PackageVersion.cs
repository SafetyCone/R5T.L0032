using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="IPackageVersion"/>
    [StrongTypeImplementationMarker]
    public class PackageVersion : TypedBase<Version>, IStrongTypeImplementationMarker,
        IPackageVersion
    {
        public PackageVersion(Version value)
            : base(value)
        {
        }
    }
}
