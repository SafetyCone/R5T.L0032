using System;


namespace R5T.L0032.F001
{
    public static class Instances
    {
        public static F003.IAuthorsOperator AuthorsOperator => F003.AuthorsOperator.Instance;
        public static F003.IBooleanOperator BooleanOperator => F003.BooleanOperator.Instance;
        public static L0066.ICharacters Characters => L0066.Characters.Instance;
        public static L0066.IContextOperator ContextOperator => L0066.ContextOperator.Instance;
        public static T0221.IEnabledOperator EnabledOperator => T0221.EnabledOperator.Instance;
        public static IItemGroupXElementOperator ItemGroupXElementOperator => F001.ItemGroupXElementOperator.Instance;
        public static L0066.INewLineOperator NewLineOperator => L0066.NewLineOperator.Instance;
        public static T000.INullableOperator NullableOperator => T000.NullableOperator.Instance;
        public static L0066.INullOperator NullOperator => L0066.NullOperator.Instance;
        public static Z000.IOutputTypes OutputTypes => Z000.OutputTypes.Instance;
        public static Z000.IPackageLicenseExpressions PackageLicenseExpressions => Z000.PackageLicenseExpressions.Instance;
        public static L0066.IPathOperator PathOperator => L0066.PathOperator.Instance;
        public static Z000.IProjectNodeNames ProjectNodeNames => Z000.ProjectNodeNames.Instance;
        public static F003.IProjectPathsOperator ProjectPathsOperator => F003.ProjectPathsOperator.Instance;
        public static Z000.IProjectSdkNames ProjectSdkNames => Z000.ProjectSdkNames.Instance;
        public static IProjectXElementOperator ProjectXElementOperator => F001.ProjectXElementOperator.Instance;
        public static IProjectXElementsOperator ProjectXElementsOperator => F001.ProjectXElementsOperator.Instance;
        public static IPropertyGroupXElementOperator PropertyGroupXElementOperator => F001.PropertyGroupXElementOperator.Instance;
        public static L0066.IStringOperator StringOperator => L0066.StringOperator.Instance;
        public static Z0057.ITargetFrameworkMonikers TargetFrameworkMonikers => Z0057.TargetFrameworkMonikers.Instance;
        public static IValues Values => F001.Values.Instance;
        public static F003.IVersionOperator VersionOperator => F003.VersionOperator.Instance;
        public static L0066.IVersions Versions => L0066.Versions.Instance;
        public static L0066.IXAttributeOperator XAttributeOperator => L0066.XAttributeOperator.Instance;
        public static L0066.IXElementOperator XElementOperator => L0066.XElementOperator.Instance;
    }
}