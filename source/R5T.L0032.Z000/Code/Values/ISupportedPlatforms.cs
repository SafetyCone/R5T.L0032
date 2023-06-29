using System;

using R5T.T0131;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.Z000
{
    /// <summary>
    /// The list of .NET project file supported platform values.
    /// This list tries to be complete, see: <see href="https://github.com/dotnet/designs/blob/main/accepted/2020/platform-exclusion/platform-exclusion.md#build-configuration-for-platforms"/>.
    /// </summary>
    [ValuesMarker]
    public partial interface ISupportedPlatforms : IValuesMarker
    {
        /// <summary>
        /// "android"
        /// </summary>
        public ISupportedPlatform Android => "android".ToSupportedPlatform();

        /// <summary>
        /// "ios"
        /// </summary>
        public ISupportedPlatform IOS => "ios".ToSupportedPlatform();

        /// <summary>
        /// "linux"
        /// </summary>
        public ISupportedPlatform Linux => "linux".ToSupportedPlatform();

        /// <summary>
        /// "macos"
        /// </summary>
        public ISupportedPlatform Macos => "macos".ToSupportedPlatform();

        /// <summary>
        /// "windows"
        /// </summary>
        public ISupportedPlatform Window => "windows".ToSupportedPlatform();


        /// <summary>
        /// "browser"
        /// </summary>
        public ISupportedPlatform Browser => "browser".ToSupportedPlatform();
    }
}
