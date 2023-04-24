using System;


namespace R5T.L0032.Z000
{
    public class PackageReferences : IPackageReferences
    {
        #region Infrastructure

        public static IPackageReferences Instance { get; } = new PackageReferences();


        private PackageReferences()
        {
        }

        #endregion
    }
}
