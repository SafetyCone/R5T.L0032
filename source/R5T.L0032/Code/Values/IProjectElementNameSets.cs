using System;

using R5T.L0030.T000;
using R5T.T0131;


namespace R5T.L0032
{
    /// <summary>
    /// Sets of project element names.
    /// Useful for specifying an ordered list of element names for sorting.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectElementNameSets : IValuesMarker
    {
        public IElementName[] MainPropertyGroupOrderedNames_Default => new[]
        {
            Instances.ProjectElementNames.TargetFramework,
            Instances.ProjectElementNames.OutputType,
            Instances.ProjectElementNames.GenerateDocumentationFile,
            Instances.ProjectElementNames.NoWarn,
        };
    }
}
