using System;
using System.Xml.Linq;


namespace R5T.L0032.F001
{
    public partial interface IProjectXElementOperator
    {
        /// <summary>
        /// <inheritdoc cref="Z001.IProjectSdkNames.NET"/>
        /// </summary>
        public XAttribute Set_Sdk_NET(XElement projectElement)
        {
            var output = Instances.ProjectXElementsOperator.Set_Sdk(
                projectElement,
                Instances.ProjectSdkNames._Platform.NET);

            return output;
        }
    }
}
