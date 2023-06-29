using System;


namespace R5T.L0032.F000
{
    public static class Instances
    {
        public static Z000.IProjectElementNames ProjectElementNames => Z000.ProjectElementNames.Instance;
        public static IProjectElementOperator ProjectElementOperator => F000.ProjectElementOperator.Instance;
        public static L0030.IXDocumentOperator XDocumentOperator => L0030.XDocumentOperator.Instance;
        public static L0030.IXElementOperator XElementOperator => L0030.XElementOperator.Instance;
    }
}