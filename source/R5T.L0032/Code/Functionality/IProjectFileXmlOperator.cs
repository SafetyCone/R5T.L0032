using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.T0132;
using R5T.T0172;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IProjectFileXmlOperator : IFunctionalityMarker
    {
        private static Internal.IProjectFileXmlOperator Internal => L0032.Internal.ProjectFileXmlOperator.Instance;


        public IProjectElement Get_ProjectElement(IProjectDocument projectDocument)
        {
            return Internal.Get_ProjectElement(projectDocument.Value);
        }

        public async Task<IProjectElement> Get_ProjectElement(IProjectFilePath projectFilePath)
        {
            var projectDocument = await this.Load_Project(projectFilePath);

            var projectElement = this.Get_ProjectElement(projectDocument);
            return projectElement;
        }

        public WasFound<IProjectElement> Has_ProjectElement(IProjectDocument projectDocument)
        {
            return Internal.Has_ProjectElement(projectDocument.Value);
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
    }
}
