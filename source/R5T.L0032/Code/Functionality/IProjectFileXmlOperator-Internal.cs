using System;
using System.Xml.Linq;

using R5T.F0000;
using R5T.L0030.Extensions;
using R5T.T0132;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.Internal
{
    [FunctionalityMarker]
    public partial interface IProjectFileXmlOperator : IFunctionalityMarker
    {
        public IProjectElement Get_ProjectElement(XDocument projectDocument)
        {
            var wasFound = this.Has_ProjectElement(projectDocument);

            return wasFound.ResultOrExceptionIfNotFound("No project element found.");
        }

        public WasFound<IProjectElement> Has_ProjectElement(XDocument projectDocument)
        {
            var wasFound = projectDocument.Has_Element(xDocument =>
            {
                var rootElementIsProject = xDocument.Root?.Is_Name(
                    Instances.ProjectElementNames.Project) ?? false;

                var output = rootElementIsProject
                    ? xDocument.Root
                    : default
                    ;

                return output;
            })
            .Convert(element => element.ToProjectElement());

            return wasFound;
        }
    }
}
