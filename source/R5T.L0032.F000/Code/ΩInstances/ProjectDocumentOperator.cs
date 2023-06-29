using System;


namespace R5T.L0032.F000
{
    public class ProjectDocumentOperator : IProjectDocumentOperator
    {
        #region Infrastructure

        public static IProjectDocumentOperator Instance { get; } = new ProjectDocumentOperator();


        private ProjectDocumentOperator()
        {
        }

        #endregion
    }
}
