using System;
using System.Threading.Tasks;

using R5T.L0032.T000;
using R5T.T0132;
using R5T.T0172;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IProjectFileOperator : IFunctionalityMarker
    {
        public Task Save(IProjectFilePath projectFilePath, IProjectElement projectElement)
        {
            return Instances.XmlOperator.Save(
                projectFilePath,
                projectElement.Value);
        }

        public void Save_Synchronous(IProjectFilePath projectFilePath, IProjectElement projectElement)
        {
            Instances.XmlOperator.Save_Synchronous(
                projectFilePath,
                projectElement.Value);
        }

        /// <inheritdoc cref="IProjectFileXmlOperator.Load_Project(IProjectFilePath)"/>
        public Task<IProjectDocument> Load(IProjectFilePath projectFilePath)
        {
            return Instances.ProjectFileXmlOperator.Load_Project(projectFilePath);
        }

        /// <inheritdoc cref="IProjectFileXmlOperator.Load_Project_Synchronous(IProjectFilePath)"/>
        public IProjectDocument Load_Synchronous(IProjectFilePath projectFilePath)
        {
            return Instances.ProjectFileXmlOperator.Load_Project_Synchronous(projectFilePath);
        }
    }
}
