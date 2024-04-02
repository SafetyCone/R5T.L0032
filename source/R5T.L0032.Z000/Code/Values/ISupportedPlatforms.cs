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
        /// <para><value>"android"</value></para>
        /// </summary>
        public ISupportedPlatform Android => "android".ToSupportedPlatform();

        /// <summary>
        /// <para><value>"ios"</value></para>
        /// </summary>
        public ISupportedPlatform IOS => "ios".ToSupportedPlatform();

        /// <summary>
        /// <para><value>"linux"</value></para>
        /// </summary>
        public ISupportedPlatform Linux => "linux".ToSupportedPlatform();

        /// <summary>
        /// <para><value>"macos"</value></para>
        /// </summary>
        public ISupportedPlatform Macos => "macos".ToSupportedPlatform();

        /// <summary>
        /// <para><value>"windows"</value></para>
        /// </summary>
        public ISupportedPlatform Window => "windows".ToSupportedPlatform();


        /// <summary>
        /// <para><value>"browser"</value></para>
        /// </summary>
        public ISupportedPlatform Browser => "browser".ToSupportedPlatform();
    }
}
