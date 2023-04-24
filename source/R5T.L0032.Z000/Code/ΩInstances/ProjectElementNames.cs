using System;


namespace R5T.L0032.Z000
{
    public class ProjectElementNames : IProjectElementNames
    {
        #region Infrastructure

        public static IProjectElementNames Instance { get; } = new ProjectElementNames();


        private ProjectElementNames()
        {
        }

        #endregion
    }
}
