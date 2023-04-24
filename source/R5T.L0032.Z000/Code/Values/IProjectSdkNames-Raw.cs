using System;

using R5T.T0131;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.Z000.Raw
{
    [ValuesMarker]
    public partial interface IProjectSdkNames : IValuesMarker
    {
        /// <summary>
		/// Microsoft.NET.Sdk: the base SDK.
		/// </summary>
		public IProjectSdkName Microsoft_NET_Sdk => "Microsoft.NET.Sdk".ToProjectSdkName();

        /// <summary>
        /// Microsoft.NET.Sdk.Web: the web SDK.
        /// </summary>
        public IProjectSdkName Microsoft_NET_Sdk_Web => "Microsoft.NET.Sdk.Web".ToProjectSdkName();

        /// <summary>
        /// Microsoft.NET.Sdk.BlazorWebAssembly: the Blazor WebAssembly SDK.
        /// </summary>
		public const string Microsoft_NET_Sdk_BlazorWebAssembly_Constant = "Microsoft.NET.Sdk.BlazorWebAssembly";

        /// <inheritdoc cref="Microsoft_NET_Sdk_BlazorWebAssembly_Constant"/>
        public IProjectSdkName Microsoft_NET_Sdk_BlazorWebAssembly => IProjectSdkNames.Microsoft_NET_Sdk_BlazorWebAssembly_Constant.ToProjectSdkName();

        /// <summary>
        /// Microsoft.NET.Sdk.Razor: the Razor SDK.
        /// </summary>
        public IProjectSdkName Microsoft_NET_Sdk_Razor => "Microsoft.NET.Sdk.Razor".ToProjectSdkName();
    }
}
