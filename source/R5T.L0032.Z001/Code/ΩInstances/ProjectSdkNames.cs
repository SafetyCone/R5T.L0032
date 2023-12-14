using System;


namespace R5T.L0032.Z001
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


namespace R5T.L0032.Z001.Raw
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
