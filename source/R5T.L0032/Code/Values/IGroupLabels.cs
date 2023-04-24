using System;

using R5T.T0131;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032
{
    [ValuesMarker]
    public partial interface IGroupLabels : IValuesMarker
    {
        public IGroupLabel COMReferences => "COM References".ToGroupLabel();
        public IGroupLabel CopyToOutput => "Copy To Output".ToGroupLabel();
        public IGroupLabel Main => "Main".ToGroupLabel();
        public IGroupLabel Package => "Package".ToGroupLabel();
        public IGroupLabel PackageReferences => "Package References".ToGroupLabel();
        public IGroupLabel ProjectReferences => "Project References".ToGroupLabel();
    }
}
