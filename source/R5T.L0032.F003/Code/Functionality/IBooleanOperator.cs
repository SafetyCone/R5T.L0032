using System;

using R5T.T0132;


namespace R5T.L0032.F003
{
    [FunctionalityMarker]
    public partial interface IBooleanOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0066.IBooleanOperator _Base => L0066.BooleanOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public string To_String_ForProjectXml(bool value)
        {
            var output = _Base.ToString_Lower(value);
            return output;
        }
    }
}
