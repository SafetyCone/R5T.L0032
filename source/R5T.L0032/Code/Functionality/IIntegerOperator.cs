using System;

using R5T.T0132;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IIntegerOperator : IFunctionalityMarker
    {
        public string ToString_ForProjectXml(int value)
        {
            var output = value.ToString();
            return output;
        }
    }
}
