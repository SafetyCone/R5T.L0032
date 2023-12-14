using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a string as the license expression for a NuGet package.
    /// <para>For a list, see <inheritdoc cref="Y000.Documentation.Links.SPDXLicenseExpressions" path="/summary"/></para>
    /// </summary>
    /// <remarks>
    /// See also: <see href="https://learn.microsoft.com/en-us/nuget/reference/nuspec#license"/>
    /// </remarks>
    [StrongTypeMarker]
    public interface IPackageLicenseExpression : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
