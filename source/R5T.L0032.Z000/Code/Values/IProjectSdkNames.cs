using System;

using R5T.T0131;

using R5T.L0032.T000;


namespace R5T.L0032.Z000
{
    [ValuesMarker]
    public partial interface IProjectSdkNames : IValuesMarker
    {
        private static Raw.IProjectSdkNames Raw => Z000.Raw.ProjectSdkNames.Instance;


        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk"/>
		public IProjectSdkName NET => Raw.Microsoft_NET_Sdk;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_Web"/>
        public IProjectSdkName Web => Raw.Microsoft_NET_Sdk_Web;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly_Constant"/>
		public const string BlazorWebAssembly_Constant = Z000.Raw.IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly_Constant;

        /// <inheritdoc cref="BlazorWebAssembly_Constant"/>
        public IProjectSdkName BlazorWebAssembly => Raw.Microsoft_NET_Sdk_BlazorWebAssembly;

        /// <inheritdoc cref="Raw.IProjectSdkNames.Microsoft_NET_Sdk_Razor"/>
        public IProjectSdkName Razor => Raw.Microsoft_NET_Sdk_Razor;
    }
}
