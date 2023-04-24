using System;


namespace R5T.L0032.Z000
{
    public class TargetFrameworkMonikers : ITargetFrameworkMonikers
    {
        #region Infrastructure

        public static ITargetFrameworkMonikers Instance { get; } = new TargetFrameworkMonikers();


        private TargetFrameworkMonikers()
        {
        }

        #endregion
    }
}
