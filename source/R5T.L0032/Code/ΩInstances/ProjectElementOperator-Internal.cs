using System;


namespace R5T.L0032.Internal
{
    public class ProjectElementOperator : IProjectElementOperator
    {
        #region Infrastructure

        public static IProjectElementOperator Instance { get; } = new ProjectElementOperator();


        private ProjectElementOperator()
        {
        }

        #endregion
    }
}
