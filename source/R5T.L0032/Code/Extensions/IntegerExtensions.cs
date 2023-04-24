using System;


namespace R5T.L0032.Extensions
{
    public static class IntegerExtensions
    {
        public static string ToString_ForProjectXml(this int value)
        {
            return Instances.IntegerOperator.ToString_ForProjectXml(value);
        }
    }
}
