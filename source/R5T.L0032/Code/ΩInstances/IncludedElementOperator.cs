using System;


namespace R5T.L0032
{
    public class IncludedElementOperator : IIncludedElementOperator
    {
        #region Infrastructure

        public static IIncludedElementOperator Instance { get; } = new IncludedElementOperator();


        private IncludedElementOperator()
        {
        }

        #endregion
    }
}
