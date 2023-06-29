using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a string as the name of a .NET SDK for a Visual Studio project.
    /// See <see href="https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview"/>
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectSdkName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
