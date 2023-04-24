using System;


namespace R5T.L0032.T000
{
    public class XElementOperator : IXElementOperator
    {
        #region Infrastructure

        public static IXElementOperator Instance { get; } = new XElementOperator();


        private XElementOperator()
        {
        }

        #endregion
    }
}
