using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IProjectPathsOperator : IFunctionalityMarker
    {
        public IProjectDirectoryPath Get_ProjectDirectoryPath(IProjectFilePath projectFilePath)
        {
            var projectDirectoryPath = Instances.PathOperator.GetParentDirectoryPath_ForFile(
                projectFilePath.Value)
                .ToProjectDirectoryPath();

            return projectDirectoryPath;
        }

        public IEnumerable<(IProjectFilePath projectFilePath, IProjectDirectoryRelativePath projectDirectoryRelativePath)> Get_ProjectDirectoryRelativePaths(
            IProjectFilePath projectFilePath,
            IEnumerable<IProjectFilePath> projectReferenceFilePaths)
        {
            var projectDirectoryPath = this.Get_ProjectDirectoryPath(projectFilePath);

            var output = projectReferenceFilePaths
                .Select(projectReferenceFilePath =>
                    (projectReferenceFilePath,
                    Instances.PathOperator.GetRelativePath(
                        projectDirectoryPath.Value,
                        projectReferenceFilePath.Value)
                        .ToProjectDirectoryRelativePath()))
                ;

            return output;
        }

        public IEnumerable<(IProjectFilePath projectFilePath, IProjectDirectoryRelativePath projectDirectoryRelativePath)> Get_ProjectDirectoryRelativePaths(
            IProjectFilePath projectFilePath,
            params IProjectFilePath[] projectReferenceFilePaths)
        {
            return this.Get_ProjectDirectoryRelativePaths(
                projectFilePath,
                projectReferenceFilePaths.AsEnumerable());
        }

        public IProjectDirectoryRelativePath Get_ProjectDirectoryRelativePath(
            IProjectFilePath projectFilePath,
            IProjectFilePath projectReferenceFilePath)
        {
            var output = this.Get_ProjectDirectoryRelativePaths(
                projectFilePath,
                projectReferenceFilePath)
                .First()
                .projectDirectoryRelativePath;

            return output;
        }
    }
}
