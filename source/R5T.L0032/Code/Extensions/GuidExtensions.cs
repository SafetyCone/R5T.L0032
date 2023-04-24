using System;


namespace R5T.L0032.Extensions
{
    public static class GuidExtensions
    {
        public static string ToString_ForCOMReference(this Guid value)
        {
            return Instances.GuidOperator.ToString_ForCOMReference(value);
        }
    }
}
