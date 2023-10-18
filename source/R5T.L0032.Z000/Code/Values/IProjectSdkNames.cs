using System;

using R5T.T0131;

using R5T.L0032.T000;


namespace R5T.L0032.Z000
{
    /// <summary>
    /// See: <see href="https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview"/>
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectSdkNames : IValuesMarker
    {
        private static Raw.IProjectSdkNames Raw => Z000.Raw.ProjectSdkNames.Instance;


        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk"/>
		public IProjectSdkName NET => Raw.Microsoft_NET_Sdk;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_Web"/>
        public IProjectSdkName Web => Raw.Microsoft_NET_Sdk_Web;

        /// <inheritdoc cref="Raw.Platform.IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly_Constant"/>
		public const string BlazorWebAssembly_Constant = Z000.Raw.Platform.IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly_Constant;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly"/>
        public IProjectSdkName BlazorWebAssembly => Raw.Microsoft_NET_Sdk_BlazorWebAssembly;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_Razor"/>
        public IProjectSdkName Razor => Raw.Microsoft_NET_Sdk_Razor;
    }
}
