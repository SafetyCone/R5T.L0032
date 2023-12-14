using System;

using R5T.T0132;


namespace R5T.L0032.F003
{
    [FunctionalityMarker]
    public partial interface IGuidOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private static L0066.IGuidOperator _Base => L0066.GuidOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public string ToString_ForCOMReference(Guid guid)
        {
            var output = _Base.ToString_D_Format(guid);
            return output;
        }
    }
}
