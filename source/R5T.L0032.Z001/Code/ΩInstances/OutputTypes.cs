using System;


namespace R5T.L0032.Z001
{
    public class OutputTypes : IOutputTypes
    {
        #region Infrastructure

        public static IOutputTypes Instance { get; } = new OutputTypes();


        private OutputTypes()
        {
        }

        #endregion
    }
}
