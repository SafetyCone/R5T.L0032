using System;


namespace R5T.L0032
{
    public class ProjectElementNameSets : IProjectElementNameSets
    {
        #region Infrastructure

        public static IProjectElementNameSets Instance { get; } = new ProjectElementNameSets();


        private ProjectElementNameSets()
        {
        }

        #endregion
    }
}
