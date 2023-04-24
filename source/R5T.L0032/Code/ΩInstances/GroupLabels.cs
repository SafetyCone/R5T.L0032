using System;


namespace R5T.L0032
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
