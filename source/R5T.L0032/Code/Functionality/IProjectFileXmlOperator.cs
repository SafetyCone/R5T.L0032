using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0172;
using R5T.T0210;
using R5T.T0221;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IProjectFileXmlOperator : IFunctionalityMarker
    {
        public Task<IProjectElement> Get_ProjectElement(IProjectFilePath projectFilePath)
        {
            return Instances.ProjectElementOperator.From(projectFilePath);
        }

        public WasFound<IProjectElement> Has_ProjectElement(IProjectDocument projectDocument)
        {
            return Instances.ProjectElementOperator.Has_ProjectElement(projectDocument.Value);
        }

        public async Task In_ProjectElementContext(
            IProjectFilePath projectFilePath,
            Action<IProjectElement> projectElementAction)
        {
            var projectElement = await this.Get_ProjectElement(projectFilePath);

            projectElementAction(projectElement);
        }

        public async Task In_ProjectElementContext(
            IProjectFilePath projectFilePath,
            Func<IProjectElement, Task> projectElementAction)
        {
            var projectElement = await this.Get_ProjectElement(projectFilePath);

            await projectElementAction(projectElement);
        }

        public async Task In_ModifyProjectElementContext(
            IProjectFilePath projectFilePath,
            Action<IProjectElement> projectElementAction)
        {
            var projectElement = await this.Get_ProjectElement(projectFilePath);

            projectElementAction(projectElement);

            await Instances.ProjectElementOperator.To_File(
                projectFilePath,
                projectElement);
        }

        /// <summary>
        /// Loads a Visual Studio project XML file.
        /// </summary>
        public async Task<IProjectDocument> Load_Project(IProjectFilePath projectFilePath)
        {
            var document = await Instances.XDocumentOperator.Load(projectFilePath);

            var output = document.ToProjectDocument();
            return output;
        }

        /// <inheritdoc cref="Load_Project(IProjectFilePath)"/>
        public IProjectDocument Load_Project_Synchronous(IProjectFilePath projectFilePath)
        {
            var document = Instances.XDocumentOperator.Load_Synchronous(projectFilePath);

            var output = document.ToProjectDocument();
            return output;
        }

        public async Task<TOutput> Query_ProjectElementContext<TOutput>(
            IProjectFilePath projectFilePath,
            Func<IProjectElement, TOutput> projectElementAction)
        {
            var projectElement = await this.Get_ProjectElement(projectFilePath);
            
            var output = projectElementAction(projectElement);
            return output;
        }

        public Task Save_Project(
            IProjectFilePath projectFilePath,
            IProjectDocument projectDocument)
        {
            return Instances.ProjectDocumentOperator.To_File(
                projectFilePath,
                projectDocument);
        }

        public void Save_Project_Synchronous(
            IProjectFilePath projectFilePath,
            IProjectDocument projectDocument)
        {
            Instances.ProjectDocumentOperator.To_File_Synchronous(
                projectFilePath,
                projectDocument);
        }

        public Task Write_ToFile(
            IProjectFilePath projectFilePath,
            IProjectFileXmlText projectFileXmlText)
        {
            return Instances.XmlOperator.Write_ToFile(
                projectFilePath,
                projectFileXmlText);
        }
    }
}
