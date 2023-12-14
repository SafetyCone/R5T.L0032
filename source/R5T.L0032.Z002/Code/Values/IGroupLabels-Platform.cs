using System;

using R5T.T0131;


namespace R5T.L0032.Z002.Platform
{
    [ValuesMarker]
    public partial interface IGroupLabels : IValuesMarker
    {
        public string COMReferences => "COM References";
        public string CopyToOutput => "Copy To Output";
        public string Custom => "Custom";
        public string Main => "Main";
        public string Package => "Package";
        public string PackageReferences => "Package References";
        public string ProjectReferences => "Project References";
    }
}
