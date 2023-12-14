using System;


namespace R5T.L0032.F001
{
    public class ProjectXElementOperator : IProjectXElementOperator
    {
        #region Infrastructure

        public static IProjectXElementOperator Instance { get; } = new ProjectXElementOperator();


        private ProjectXElementOperator()
        {
        }

        #endregion
    }
}
