using System;


namespace R5T.L0032
{
    public class IntegerOperator : IIntegerOperator
    {
        #region Infrastructure

        public static IIntegerOperator Instance { get; } = new IntegerOperator();


        private IntegerOperator()
        {
        }

        #endregion
    }
}
