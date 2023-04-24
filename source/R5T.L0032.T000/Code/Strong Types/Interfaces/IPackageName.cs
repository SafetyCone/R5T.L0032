using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// The name of a NuGet package.
    /// </summary>
    [StrongTypeMarker]
    public interface IPackageName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
