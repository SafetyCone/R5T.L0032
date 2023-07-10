using System;

using R5T.T0131;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.Z000
{
    /// <summary>
	/// See: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks"/>
	/// And for what frameworks support what frameworks: https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0#select-net-standard-version
	/// </summary>
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikers : IValuesMarker
    {
        /// <summary>
		/// When you need a target framework moniker, but don't want to think about it.
		/// Chooses <see cref="NET_6"/> as the default.
		/// </summary>
		public ITargetFrameworkMoniker Default => this.NET_6;
        /// <summary>
        /// When you want to use the standard target framework moniker.
        /// /// Chooses <see cref="NET_6"/> as the standard.
        /// </summary>
        public ITargetFrameworkMoniker Standard => this.NET_6;


        /// <summary>
        /// net6.0 - .NET 6.0.
        /// </summary>
        public const string NET_6_Constant = "net6.0";
        /// <inheritdoc cref="NET_6_Constant"/>
        public ITargetFrameworkMoniker NET_6 => ITargetFrameworkMonikers.NET_6_Constant.ToTargetFrameworkMoniker();
        public ITargetFrameworkMoniker NET_6_Windows => "net6.0-windows".ToTargetFrameworkMoniker();
        public const string NET_5_Constant = "net5.0";
        public ITargetFrameworkMoniker NET_5 => ITargetFrameworkMonikers.NET_5_Constant.ToTargetFrameworkMoniker();
        /// <summary>
        /// Useful if you want to allow old .NET Framework (4.6.2 and higher) support.
        /// </summary>
        public ITargetFrameworkMoniker NET_Standard2_0 => "netstandard2.0".ToTargetFrameworkMoniker();
        /// <summary>
        /// netstandard2.1
        /// </summary>
        /// <remarks>
        /// Note: as of this version of .NET Standard, the old .NET framework is no longer supported.
        /// </remarks>
        public ITargetFrameworkMoniker NET_Standard2_1 => "netstandard2.1".ToTargetFrameworkMoniker();
        public ITargetFrameworkMoniker NET_Core3_1 => "netcoreapp3.1".ToTargetFrameworkMoniker();
        public ITargetFrameworkMoniker NET_Framework4_8 => "net48".ToTargetFrameworkMoniker();
    }
}
