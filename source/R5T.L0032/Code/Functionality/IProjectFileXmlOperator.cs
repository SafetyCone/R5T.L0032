using System;
using System.Threading.Tasks;
using System.Xml.Linq;

using R5T.F0000;
using R5T.L0030.Extensions;
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

        public WasFound<IProjectElement> Has_ProjectElement(IProjectDocument projectDocument)
        {
            return Internal.Has_ProjectElement(projectDocument.Value);
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
    }
}
