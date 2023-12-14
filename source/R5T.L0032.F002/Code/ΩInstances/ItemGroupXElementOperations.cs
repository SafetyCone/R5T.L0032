using System;


namespace R5T.L0032.F002
{
    public class ItemGroupXElementOperations : IItemGroupXElementOperations
    {
        #region Infrastructure

        public static IItemGroupXElementOperations Instance { get; } = new ItemGroupXElementOperations();


        private ItemGroupXElementOperations()
        {
        }

        #endregion
    }
}
