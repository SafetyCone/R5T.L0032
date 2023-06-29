using System;
using System.Threading.Tasks;
using System.Xml.Linq;

using R5T.F0000;
using R5T.L0030.Extensions;
using R5T.T0132;
using R5T.T0172;
using R5T.T0210;
using R5T.T0210.Extensions;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.F000
{
    [FunctionalityMarker]
    public partial interface IProjectElementOperator : IFunctionalityMarker
    {
        public IProjectElement From_Text(string projectElementXmlText)
        {
            var output = Instances.XElementOperator.Parse(projectElementXmlText)
                .ToProjectElement();

            return output;
        }

        public IProjectElement From(IProjectFileXmlText projectFileXmlText)
        {
            var output = this.From_Text(projectFileXmlText.Value);
            return output;
        }

        /// <summary>
        /// Allows getting a project element asynchronously from project file XML text.
        /// Useful for cases where the project file XML text is asynchronously loaded from a file.
        /// </summary>
        public async Task<IProjectElement> From(Task<IProjectFileXmlText> gettingProjectFileXmlText)
        {
            var projectFileXmlText = await gettingProjectFileXmlText;

            var output = this.From(projectFileXmlText);
            return output;
        }

        public async Task<IProjectElement> From(IProjectFilePath projectFilePath)
        {
            var xElement = await Instances.XElementOperator.From(projectFilePath);

            var output = xElement.ToProjectElement();
            return output;
        }

        public IProjectElement Get_ProjectElement(XDocument projectDocument)
        {
            var wasFound = this.Has_ProjectElement(projectDocument);

            return wasFound.ResultOrExceptionIfNotFound("No project element found.");
        }

        public WasFound<IProjectElement> Has_ProjectElement(XDocument projectDocument)
        {
            var wasFound = projectDocument.Has_Element(xDocument =>
            {
                var rootElementIsProject = xDocument.Root
                    ?.Is_Name(
                        Instances.ProjectElementNames.Project)
                    ?? false;

                var output = rootElementIsProject
                    ? xDocument.Root
                    : default
                    ;

                return output;
            })
            .Convert(element => element.ToProjectElement());

            return wasFound;
        }

        public string To_Text(IProjectElement projectElement)
        {
            var output = Instances.XElementOperator.To_Text(projectElement.Value);
            return output;
        }

        public IProjectFileXmlText To_ProjectFileXmlText(IProjectElement projectElement)
        {
            var output = this.To_Text(projectElement)
                .ToProjectFileXmlText();

            return output;
        }

        public Task To_File(
            IProjectFilePath projectFilePath,
            IProjectElement projectElement)
        {
            return Instances.XElementOperator.To_File(
                projectFilePath,
                projectElement.Value);
        }

        public void To_File_Synchronous(
            IProjectFilePath projectFilePath,
            IProjectElement projectElement)
        {
            Instances.XElementOperator.To_File_Synchronous(
                projectFilePath,
                projectElement.Value);
        }
    }
}
