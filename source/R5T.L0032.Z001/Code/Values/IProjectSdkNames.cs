using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.L0032.Z001
{
    /// <summary>
    /// See: <see href="https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview"/>
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectSdkNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private static Raw.IProjectSdkNames _Raw => Raw.ProjectSdkNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk"/>
        public string NET => _Raw.Microsoft_NET_Sdk;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_Web"/>
        public string Web => _Raw.Microsoft_NET_Sdk_Web;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly"/>
        public string BlazorWebAssembly => _Raw.Microsoft_NET_Sdk_BlazorWebAssembly;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_Razor"/>
        public string Razor => _Raw.Microsoft_NET_Sdk_Razor;
    }
}
