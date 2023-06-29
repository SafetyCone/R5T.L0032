using System;


namespace R5T.L0032
{
    public class ProjectXmlOperations : IProjectXmlOperations
    {
        #region Infrastructure

        public static IProjectXmlOperations Instance { get; } = new ProjectXmlOperations();


        private ProjectXmlOperations()
        {
        }

        #endregion
    }
}
