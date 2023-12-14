using System;


namespace R5T.L0032.Z002
{
    public class GroupLabels : IGroupLabels
    {
        #region Infrastructure

        public static IGroupLabels Instance { get; } = new GroupLabels();


        private GroupLabels()
        {
        }

        #endregion
    }
}


namespace R5T.L0032.Z002.Platform
{
    public class GroupLabels : IGroupLabels
    {
        #region Infrastructure

        public static IGroupLabels Instance { get; } = new GroupLabels();


        private GroupLabels()
        {
        }

        #endregion
    }
}
