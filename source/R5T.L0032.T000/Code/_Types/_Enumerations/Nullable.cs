using System;

using R5T.T0142;


namespace R5T.L0032.T000
{
    /// <summary>
    /// See <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/language#nullable"/>.
    /// </summary>
    [DataTypeMarker]
    public enum Nullable
    {
        /// <summary>
        /// Disabled - the default value.
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Enabled
        /// </summary>
        Enabled,

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
