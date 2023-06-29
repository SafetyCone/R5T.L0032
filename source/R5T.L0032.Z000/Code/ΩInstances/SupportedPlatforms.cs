using System;


namespace R5T.L0032.Z000
{
    public class SupportedPlatforms : ISupportedPlatforms
    {
        #region Infrastructure

        public static ISupportedPlatforms Instance { get; } = new SupportedPlatforms();


        private SupportedPlatforms()
        {
        }

        #endregion
    }
}
