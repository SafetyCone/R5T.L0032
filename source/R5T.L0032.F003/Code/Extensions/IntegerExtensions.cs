using System;


namespace R5T.L0032.F003.Extensions
{
    public static class IntegerExtensions
    {
        public static string To_String_ForProjectXml(this int value)
        {
            return Instances.IntegerOperator.ToString_ForProjectXml(value);
        }
    }
}
