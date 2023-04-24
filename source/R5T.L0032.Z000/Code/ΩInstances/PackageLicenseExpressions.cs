using System;


namespace R5T.L0032.Z000
{
    public class PackageLicenseExpressions : IPackageLicenseExpressions
    {
        #region Infrastructure

        public static IPackageLicenseExpressions Instance { get; } = new PackageLicenseExpressions();


        private PackageLicenseExpressions()
        {
        }

        #endregion
    }
}
