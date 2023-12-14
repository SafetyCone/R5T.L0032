using System;


namespace R5T.L0032.F003
{
    public class ProjectPathsOperator : IProjectPathsOperator
    {
        #region Infrastructure

        public static IProjectPathsOperator Instance { get; } = new ProjectPathsOperator();


        private ProjectPathsOperator()
        {
        }

        #endregion
    }
}
