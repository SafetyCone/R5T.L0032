using System;

using R5T.T0131;

using R5T.L0032.T000;
using R5T.T0143;


namespace R5T.L0032.Z000
{
    /// <summary>
    /// See: <see href="https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview"/>
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectSdkNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z001.IProjectSdkNames _Platform => Z001.ProjectSdkNames.Instance;

        [Ignore]
        public Raw.IProjectSdkNames _Raw => Raw.ProjectSdkNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk"/>
        public IProjectSdkName NET => _Raw.Microsoft_NET_Sdk;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_Web"/>
        public IProjectSdkName Web => _Raw.Microsoft_NET_Sdk_Web;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly"/>
        public IProjectSdkName BlazorWebAssembly => _Raw.Microsoft_NET_Sdk_BlazorWebAssembly;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_Razor"/>
        public IProjectSdkName Razor => _Raw.Microsoft_NET_Sdk_Razor;
    }
}
