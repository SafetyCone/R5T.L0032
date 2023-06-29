using System;
using System.Xml.Linq;

using R5T.F0000;
using R5T.L0030.Extensions;
using R5T.T0132;

using R5T.L0032.T000;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface ICustomPropertyGroupElementOperator : IFunctionalityMarker
    {
        public void Ensure_HasPrivateGitHubRepositoryProperty(ICustomPropertyGroupElement customPropertyGroupElement)
        {
            customPropertyGroupElement.Value.Ensure_HasChild(
                Instances.ProjectElementNames.PrivateGitHubRepository);
        }

        public WasFound<XElement> Has_PrivateGitHubRepositoryProperty(ICustomPropertyGroupElement customPropertyGroupElement)
        {
            var output = customPropertyGroupElement.Value.Has_Child(
                Instances.ProjectElementNames.PrivateGitHubRepository);

            return output;
        }
    }
}
