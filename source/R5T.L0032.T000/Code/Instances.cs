using System;


namespace R5T.L0032.T000
{
    public static class Instances
    {
        public static F0000.IGuidOperator GuidOperator => F0000.GuidOperator.Instance;
        public static IVersionOperator VersionOperator => T000.VersionOperator.Instance;
        public static IStringOperator StringOperator => T000.StringOperator.Instance;
        public static IXDocumentOperator XDocumentOperator => T000.XDocumentOperator.Instance;
        public static IXElementOperator XElementOperator => T000.XElementOperator.Instance;
    }
}