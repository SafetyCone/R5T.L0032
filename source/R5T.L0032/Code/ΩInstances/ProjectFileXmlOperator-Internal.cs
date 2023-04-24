using System;


namespace R5T.L0032.Internal
{
    public class ProjectFileXmlOperator : IProjectFileXmlOperator
    {
        #region Infrastructure

        public static IProjectFileXmlOperator Instance { get; } = new ProjectFileXmlOperator();


        private ProjectFileXmlOperator()
        {
        }

        #endregion
    }
}
