using System;


namespace R5T.L0032.F003.Extensions
{
    public static class VersionExtensions
    {
        public static string To_String_ForProjectXml(this Version value)
        {
            return Instances.VersionOperator.ToString_ForProjectXml(value);
        }
    }
}
