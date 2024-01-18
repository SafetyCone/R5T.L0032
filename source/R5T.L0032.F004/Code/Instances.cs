using System;


namespace R5T.L0032.F004
{
    public static class Instances
    {
        public static F003.IAuthorsOperator AuthorsOperator => F003.AuthorsOperator.Instance;
        public static F003.IBooleanOperator BooleanOperator => F003.BooleanOperator.Instance;
        public static L0066.IContextOperator ContextOperator => L0066.ContextOperator.Instance;
        public static L0066.INewLineOperator NewLineOperator => L0066.NewLineOperator.Instance;
        public static L0066.INullOperator NullOperator => L0066.NullOperator.Instance;
        public static F003.IProjectPathsOperator ProjectPathsOperator => F003.ProjectPathsOperator.Instance;
        public static IProjectXElementsOperator ProjectXElementsOperator => F004.ProjectXElementsOperator.Instance;
        public static Z001.IProjectNodeNames ProjectNodeNames => Z001.ProjectNodeNames.Instance;
        public static F003.IVersionOperator VersionOperator => F003.VersionOperator.Instance;
        public static L0066.IXAttributeOperator XAttributeOperator => L0066.XAttributeOperator.Instance;
        public static L0066.IXElementOperator XElementOperator => L0066.XElementOperator.Instance;
    }
}