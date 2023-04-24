using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="IPackageName"/>
    [StrongTypeImplementationMarker]
    public class PackageName : TypedBase<string>, IStrongTypeImplementationMarker,
        IPackageName
    {
        public PackageName(string value)
            : base(value)
        {
        }
    }
}
