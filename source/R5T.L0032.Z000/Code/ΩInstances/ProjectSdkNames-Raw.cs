using System;


namespace R5T.L0032.Z000.Raw
{
    public class ProjectSdkNames : IProjectSdkNames
    {
        #region Infrastructure

        public static IProjectSdkNames Instance { get; } = new ProjectSdkNames();


        private ProjectSdkNames()
        {
        }

        #endregion
    }
}
