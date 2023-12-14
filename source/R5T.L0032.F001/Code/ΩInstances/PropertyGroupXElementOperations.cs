using System;


namespace R5T.L0032.F001
{
    public class PropertyGroupXElementOperations : IPropertyGroupXElementOperations
    {
        #region Infrastructure

        public static IPropertyGroupXElementOperations Instance { get; } = new PropertyGroupXElementOperations();


        private PropertyGroupXElementOperations()
        {
        }

        #endregion
    }
}
