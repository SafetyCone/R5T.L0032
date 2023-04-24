using System;


namespace R5T.L0032.Internal
{
    public class ProjectXmlOperator : IProjectXmlOperator
    {
        #region Infrastructure

        public static IProjectXmlOperator Instance { get; } = new ProjectXmlOperator();


        private ProjectXmlOperator()
        {
        }

        #endregion
    }
}
