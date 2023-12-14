using System;


namespace R5T.L0032.F003.Extensions
{
    public static class GuidExtensions
    {
        public static string To_String_ForCOMReference(this Guid value)
        {
            return Instances.GuidOperator.ToString_ForCOMReference(value);
        }
    }
}
