using System;


namespace R5T.L0032
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
