using System;


namespace R5T.L0032.T000
{
    public class NullableOperator : INullableOperator
    {
        #region Infrastructure

        public static INullableOperator Instance { get; } = new NullableOperator();


        private NullableOperator()
        {
        }

        #endregion
    }
}
