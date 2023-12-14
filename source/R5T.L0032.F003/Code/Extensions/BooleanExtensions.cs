using System;


namespace R5T.L0032.F003.Extensions
{
    public static class BooleanExtensions
    {
        public static string To_String_ForProjectXml(this bool value)
        {
            return Instances.BooleanOperator.To_String_ForProjectXml(value);
        }
    }
}
