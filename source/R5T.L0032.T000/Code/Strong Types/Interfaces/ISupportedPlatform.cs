using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a string as one of the supported platform values for a .NET project file.
    /// See: <see href="https://learn.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-6.0&amp;tabs=visual-studio#browser-compatibility-analyzer-for-blazor-webassembly"/>
    /// Also, see: <see href="https://github.com/dotnet/designs/blob/main/accepted/2020/platform-exclusion/platform-exclusion.md#build-configuration-for-platforms"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface ISupportedPlatform : IStrongTypeMarker,
        ITyped<string>
    {
    }
}