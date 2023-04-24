using System;


namespace R5T.L0032.Z000
{
    public class COMReferences : ICOMReferences
    {
        #region Infrastructure

        public static ICOMReferences Instance { get; } = new COMReferences();


        private COMReferences()
        {
        }

        #endregion
    }
}
