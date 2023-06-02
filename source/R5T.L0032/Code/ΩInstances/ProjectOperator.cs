using System;


namespace R5T.L0032
{
    public class ProjectOperator : IProjectOperator
    {
        #region Infrastructure

        public static IProjectOperator Instance { get; } = new ProjectOperator();


        private ProjectOperator()
        {
        }

        #endregion
    }
}
