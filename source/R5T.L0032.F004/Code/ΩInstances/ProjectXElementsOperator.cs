using System;


namespace R5T.L0032.F004
{
    public class ProjectXElementsOperator : IProjectXElementsOperator
    {
        #region Infrastructure

        public static IProjectXElementsOperator Instance { get; } = new ProjectXElementsOperator();


        private ProjectXElementsOperator()
        {
        }

        #endregion
    }
}
