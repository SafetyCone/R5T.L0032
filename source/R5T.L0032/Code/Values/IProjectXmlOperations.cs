using System;

using R5T.L0032.T000;
using R5T.T0131;
using R5T.T0221;


namespace R5T.L0032
{
    [ValuesMarker]
    public partial interface IProjectXmlOperations : IValuesMarker
    {
        public WasFound<IProjectReferenceItemGroupElement> Has_ProjectReferenceItemGroupElement(IProjectElement projectElement)
        {
            return Instances.ProjectXmlOperator.Has_ProjectReferenceItemGroup(projectElement);
        }
    }
}
