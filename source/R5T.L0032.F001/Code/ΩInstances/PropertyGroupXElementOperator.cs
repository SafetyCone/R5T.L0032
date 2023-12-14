using System;


namespace R5T.L0032.F001
{
    public class PropertyGroupXElementOperator : IPropertyGroupXElementOperator
    {
        #region Infrastructure

        public static IPropertyGroupXElementOperator Instance { get; } = new PropertyGroupXElementOperator();


        private PropertyGroupXElementOperator()
        {
        }

        #endregion
    }
}
