using System;

using R5T.T0131;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.Z000.Raw
{
    /// <inheritdoc cref="Z000.IProjectSdkNames"/>
    [ValuesMarker]
    public partial interface IProjectSdkNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private static Z001.Raw.IProjectSdkNames _Platform => Z001.Raw.ProjectSdkNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z001.Raw.IProjectSdkNames.Microsoft_NET_Sdk"/>
        public IProjectSdkName Microsoft_NET_Sdk => _Platform.Microsoft_NET_Sdk.ToProjectSdkName();

        /// <inheritdoc cref="Z001.Raw.IProjectSdkNames.Microsoft_NET_Sdk_Web"/>
        public IProjectSdkName Microsoft_NET_Sdk_Web => _Platform.Microsoft_NET_Sdk_Web.ToProjectSdkName();

        /// <inheritdoc cref="Z001.Raw.IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly"/>
        public IProjectSdkName Microsoft_NET_Sdk_BlazorWebAssembly => _Platform.Microsoft_NET_Sdk_BlazorWebAssembly.ToProjectSdkName();

        /// <inheritdoc cref="Z001.Raw.IProjectSdkNames.Microsoft_NET_Sdk_Razor"/>
        public IProjectSdkName Microsoft_NET_Sdk_Razor => _Platform.Microsoft_NET_Sdk_Razor.ToProjectSdkName();
    }
}
