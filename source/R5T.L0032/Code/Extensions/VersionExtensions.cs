using System;


namespace R5T.L0032.Extensions
{
    public static class VersionExtensions
    {
        public static string ToString_ForProjectXml(this Version value)
        {
            return Instances.VersionOperator.ToString_ForProjectXml(value);
        }
    }
}
