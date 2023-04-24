using System;

using R5T.T0132;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IGuidOperator : IFunctionalityMarker
    {
        private static F0000.IGuidOperator Base => F0000.GuidOperator.Instance;


        public string ToString_ForCOMReference(Guid guid)
        {
            var output = Base.ToString_D_Format(guid);
            return output;
        }
    }
}
