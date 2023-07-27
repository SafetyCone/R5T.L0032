using System;

using R5T.T0178;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a string as the .NET framework for use in Visual Studio project files.
    /// See <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks"/>.
    /// </summary>
    [StrongTypeMarker]
    [Obsolete("Use R5T.T0218.ITargetFrameworkMoniker instead.")]
    public interface ITargetFrameworkMoniker : IStrongTypeMarker,
        T0218.ITargetFrameworkMoniker
    {
    }
}
