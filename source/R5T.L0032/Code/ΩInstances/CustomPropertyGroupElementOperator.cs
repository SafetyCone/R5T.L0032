using System;


namespace R5T.L0032
{
    public class CustomPropertyGroupElementOperator : ICustomPropertyGroupElementOperator
    {
        #region Infrastructure

        public static ICustomPropertyGroupElementOperator Instance { get; } = new CustomPropertyGroupElementOperator();


        private CustomPropertyGroupElementOperator()
        {
        }

        #endregion
    }
}
