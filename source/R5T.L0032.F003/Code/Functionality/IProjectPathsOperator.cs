using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.L0032.F003
{
    [FunctionalityMarker]
    public partial interface IProjectPathsOperator : IFunctionalityMarker
    {
        public string Get_ProjectDirectoryPath(string projectFilePath)
        {
            var output = Instances.PathOperator.Get_ParentDirectoryPath_ForFile(projectFilePath);
            return output;
        }

        public string Get_RelativeReferenceProjectFilePath(
            string projectFilePath,
            string referenceProjectFilePath)
        {
            var projectDirectoryPath = this.Get_ProjectDirectoryPath(projectFilePath);

            var output = this.Get_RelativeReferenceProjectFilePath_UsingProjectDirectoryPath(
                projectDirectoryPath,
                referenceProjectFilePath);

            return output;
        }

        public string[] Get_RelativeReferenceProjectFilePaths(
            string projectFilePath,
            IEnumerable<string> referenceProjectFilePaths)
        {
            var projectDirectoryPath = this.Get_ProjectDirectoryPath(projectFilePath);

            var output = referenceProjectFilePaths
                .Select(referenceProjectFilePath => this.Get_RelativeReferenceProjectFilePath_UsingProjectDirectoryPath(
                    projectDirectoryPath,
                    referenceProjectFilePath))
                .Now();

            return output;
        }

        public string Get_RelativeReferenceProjectFilePath_UsingProjectDirectoryPath(
            string projectDirectoryPath,
            string referenceProjectFilePath)
        {
            var output = Instances.PathOperator.Get_RelativePath(
                projectDirectoryPath,
                referenceProjectFilePath);

            return output;
        }
    }
}
