using System;


namespace R5T.L0032.Z000
{
    public class ProjectNodeNames : IProjectNodeNames
    {
        #region Infrastructure

        public static IProjectNodeNames Instance { get; } = new ProjectNodeNames();


        private ProjectNodeNames()
        {
        }

        #endregion
    }
}
