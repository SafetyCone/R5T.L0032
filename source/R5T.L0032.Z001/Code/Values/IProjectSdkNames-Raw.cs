using System;

using R5T.T0131;


namespace R5T.L0032.Z001.Raw
{
    /// <inheritdoc cref="Z001.IProjectSdkNames"/>
    [ValuesMarker]
    public partial interface IProjectSdkNames : IValuesMarker
    {
        /// <summary>
		/// "Microsoft.NET.Sdk" - the base SDK.
		/// </summary>
        public const string Microsoft_NET_Sdk_Constant = "Microsoft.NET.Sdk";

        /// <inheritdoc cref="Microsoft_NET_Sdk_Constant"/>
        public string Microsoft_NET_Sdk => Microsoft_NET_Sdk_Constant;

        /// <summary>
        /// "Microsoft.NET.Sdk.Web" - the web SDK.
        /// </summary>
        public const string Microsoft_NET_Sdk_Web_Constant = "Microsoft.NET.Sdk.Web";

        /// <inheritdoc cref="Microsoft_NET_Sdk_Web_Constant"/>
        public string Microsoft_NET_Sdk_Web => Microsoft_NET_Sdk_Web_Constant;

        /// <summary>
        /// "Microsoft.NET.Sdk.BlazorWebAssembly" - the Blazor WebAssembly SDK.
        /// </summary>
		public const string Microsoft_NET_Sdk_BlazorWebAssembly_Constant = "Microsoft.NET.Sdk.BlazorWebAssembly";

        /// <inheritdoc cref="Microsoft_NET_Sdk_BlazorWebAssembly_Constant"/>
        public string Microsoft_NET_Sdk_BlazorWebAssembly => Microsoft_NET_Sdk_BlazorWebAssembly_Constant;

        /// <summary>
        /// "Microsoft.NET.Sdk.Razor" - the Razor SDK.
        /// </summary>
        public const string Microsoft_NET_Sdk_Razor_Constant = "Microsoft.NET.Sdk.Razor";

        /// <inheritdoc cref="Microsoft_NET_Sdk_Razor_Constant"/>
        public string Microsoft_NET_Sdk_Razor => Microsoft_NET_Sdk_Razor_Constant;
    }
}
