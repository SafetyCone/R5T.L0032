using System;


namespace R5T.L0032.T000
{
    public static class Instances
    {
        public static IStringOperator StringOperator => T000.StringOperator.Instance;
        public static IStrings Strings => T000.Strings.Instance;
        public static L0066.ISwitchOperator SwitchOperator => L0066.SwitchOperator.Instance;
        public static IXDocumentOperator XDocumentOperator => T000.XDocumentOperator.Instance;
        public static IXElementOperator XElementOperator => T000.XElementOperator.Instance;
    }
}