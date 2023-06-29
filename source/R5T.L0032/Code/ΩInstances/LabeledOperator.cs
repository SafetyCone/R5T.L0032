using System;


namespace R5T.L0032
{
    public class LabeledOperator : ILabeledOperator
    {
        #region Infrastructure

        public static ILabeledOperator Instance { get; } = new LabeledOperator();


        private LabeledOperator()
        {
        }

        #endregion
    }
}
