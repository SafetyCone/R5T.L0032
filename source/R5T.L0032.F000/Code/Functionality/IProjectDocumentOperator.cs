using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0172;

using R5T.L0032.T000;


namespace R5T.L0032.F000
{
    /// <summary>
    /// Strongly-typed <see cref="IProjectDocument"/> and <see cref="IProjectFilePath"/> level abstraction methods.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectDocumentOperator : IFunctionalityMarker
    {
        public IProjectElement Get_ProjectElement(IProjectDocument projectDocument)
        {
            return Instances.ProjectElementOperator.Get_ProjectElement(projectDocument.Value);
        }

        public Task To_File(
            IProjectFilePath projectFilePath,
            IProjectDocument projectDocument)
        {
            return Instances.XDocumentOperator.Save(
                projectFilePath,
                projectDocument.Value);
        }

        public void To_File_Synchronous(
            IProjectFilePath projectFilePath,
            IProjectDocument projectDocument)
        {
            Instances.XDocumentOperator.Save_Synchronous(
                projectFilePath,
                projectDocument.Value);
        }
    }
}
