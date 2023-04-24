using System;


namespace R5T.L0032.Z000
{
    public class CopyToOutputDirectives : ICopyToOutputDirectives
    {
        #region Infrastructure

        public static ICopyToOutputDirectives Instance { get; } = new CopyToOutputDirectives();


        private CopyToOutputDirectives()
        {
        }

        #endregion
    }
}
