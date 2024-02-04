using System;

using R5T.T0142;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Values for the Visual Studio (MSBuild) XML project file nullable property.
    /// </summary>
    /// <remarks>
    /// See <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/language#nullable"/>.
    /// </remarks>
    [DataTypeMarker]
    public enum Nullable
    {
        /// <summary>
        /// Disabled - the default value.
        /// </summary>
        Disable = 0,

        /// <summary>
        /// Enabled
        /// </summary>
        Enable,

        /// <summary>
        /// Warnings
        /// </summary>
        Warnings,

        /// <summary>
        /// Annotations
        /// </summary>
        Annotations
    }
}
