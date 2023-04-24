using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="IPackageLicenseExpression"/>
    [StrongTypeImplementationMarker]
    public class PackageLicenseExpression : TypedBase<string>, IStrongTypeImplementationMarker,
        IPackageLicenseExpression
    {
        public PackageLicenseExpression(string value)
            : base(value)
        {
        }
    }
}
