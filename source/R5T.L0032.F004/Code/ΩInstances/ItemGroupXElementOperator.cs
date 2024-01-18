using System;


namespace R5T.L0032.F004
{
    public class ItemGroupXElementOperator : IItemGroupXElementOperator
    {
        #region Infrastructure

        public static IItemGroupXElementOperator Instance { get; } = new ItemGroupXElementOperator();


        private ItemGroupXElementOperator()
        {
        }

        #endregion
    }
}
