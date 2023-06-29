using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a string as the license expression for a NuGet package.
    /// </summary>
    [StrongTypeMarker]
    public interface IPackageLicenseExpression : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
