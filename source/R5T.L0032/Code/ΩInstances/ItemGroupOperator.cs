using System;


namespace R5T.L0032
{
    public class ItemGroupOperator : IItemGroupOperator
    {
        #region Infrastructure

        public static IItemGroupOperator Instance { get; } = new ItemGroupOperator();


        private ItemGroupOperator()
        {
        }

        #endregion
    }
}
