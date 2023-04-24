using System;

using R5T.T0131;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.Z000
{
    [ValuesMarker]
    public partial interface IPackageReferences : IValuesMarker
    {
        /// <summary>
        /// Microsoft.NET.Test.Sdk, 17.0.0
        /// </summary>
        private static readonly Lazy<PackageReference> zMicrosoft_NET_Test_Sdk = new Lazy<PackageReference>(() => new PackageReference
        {
            Name = "Microsoft.NET.Test.Sdk".ToPackageName(),
            Version = "17.0.0".ToPackageVersion(),
        });
        public PackageReference Microsoft_NET_Test_Sdk => IPackageReferences.zMicrosoft_NET_Test_Sdk.Value;

        /// <summary>
        /// MSTest.TestAdapter, 2.2.8
        /// </summary>
        private static readonly Lazy<PackageReference> zMSTest_TestAdapter = new Lazy<PackageReference>(() => new PackageReference
        {
            Name = "MSTest.TestAdapter".ToPackageName(),
            Version = "2.2.8".ToPackageVersion(),
        });
        public PackageReference MSTest_TestAdapter => IPackageReferences.zMSTest_TestAdapter.Value;
    }
}
