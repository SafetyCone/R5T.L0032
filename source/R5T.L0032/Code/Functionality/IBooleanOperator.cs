using System;

using R5T.T0132;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IBooleanOperator : IFunctionalityMarker
    {
        private static F0000.IBooleanOperator Base => F0000.BooleanOperator.Instance;


        public string ToString_ForProjectXml(bool value)
        {
            var output = Base.ToString_Lower(value);
            return output;
        }
    }
}
