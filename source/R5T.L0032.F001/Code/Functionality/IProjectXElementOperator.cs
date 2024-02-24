using System;
using System.Xml.Linq;

using R5T.L0032.T000;
using R5T.T0132;
using R5T.T0172;


namespace R5T.L0032.F001
{
    /// <summary>
    /// XElement-level Visual Studio project file XML element functionality.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectXElementOperator : IFunctionalityMarker,
        F004.IProjectXElementOperator
    {
        public XAttribute Set_Sdk(
            XElement projectElement,
            IProjectSdkName projectSdkName)
        {
            var output = this.Set_Sdk(
                projectElement,
                projectSdkName.Value);

            return output;
        }

        public void To_File_Separated_Synchronous(
            IProjectFilePath projectFilePath,
            IProjectElement projectElement)
        {
            this.To_File_Separated_Synchronous(
                projectFilePath.Value,
                projectElement.Value);
        }
    }
}
