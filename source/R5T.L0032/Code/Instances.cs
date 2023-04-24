using System;


namespace R5T.L0032
{
    public static class Instances
    {
        public static IBooleanOperator BooleanOperator => L0032.BooleanOperator.Instance;
        public static Z000.ICopyToOutputDirectives CopyToOutputDirectives => Z000.CopyToOutputDirectives.Instance;
        public static F0120.ICopyrightOperator CopyrightOperator => F0120.CopyrightOperator.Instance;
        public static IIntegerOperator IntegerOperator => L0032.IntegerOperator.Instance;
        public static IGroupLabels GroupLabels => L0032.GroupLabels.Instance;
        public static IGuidOperator GuidOperator => L0032.GuidOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static Z000.IProjectElementNames ProjectElementNames => Z000.ProjectElementNames.Instance;
        public static IProjectPathsOperator ProjectPathsOperator => L0032.ProjectPathsOperator.Instance;
        public static IProjectFileXmlOperator ProjectFileXmlOperator => L0032.ProjectFileXmlOperator.Instance;
        public static IVersionOperator VersionOperator => L0032.VersionOperator.Instance;
        public static L0030.IXDocumentOperator XDocumentOperator => L0030.XDocumentOperator.Instance;
        public static L0030.IXElementOperator XElementOperator => L0030.XElementOperator.Instance;
        public static L0030.IXmlOperator XmlOperator => L0030.XmlOperator.Instance;
    }
}