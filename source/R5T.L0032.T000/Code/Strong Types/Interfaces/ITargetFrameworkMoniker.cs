using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Specifies the .NET framework for use in Visual Studio project files.
    /// See <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface ITargetFrameworkMoniker : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
