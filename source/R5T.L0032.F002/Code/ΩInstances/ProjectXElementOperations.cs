using System;


namespace R5T.L0032.F002
{
    public class ProjectXElementOperations : IProjectXElementOperations
    {
        #region Infrastructure

        public static IProjectXElementOperations Instance { get; } = new ProjectXElementOperations();


        private ProjectXElementOperations()
        {
        }

        #endregion
    }
}
