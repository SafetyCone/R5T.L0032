using System;


namespace R5T.L0032.Extensions
{
    public static class BooleanExtensions
    {
        public static string ToString_ForProjectXml(this bool value)
        {
            return Instances.BooleanOperator.ToString_ForProjectXml(value);
        }
    }
}
