using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.L0032.F004
{
    /// <summary>
    /// Contains XElement-level operations on only the project XElement.
    /// For operations on all of the XElement descendants of the project XElement, and not just the project XElement, see (the regrettably closely named) <see cref="IProjectXElementsOperator"/>.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectXElementOperator : IFunctionalityMarker
    {
        public XAttribute Acquire_SdkAttribute(XElement projectElement)
        {
            var output = Instances.ProjectXElementsOperator.Acquire_SdkAttribute(projectElement);
            return output;
        }

        public XAttribute Get_SdkAttribute(XElement projectElement)
        {
            var output = Instances.ProjectXElementsOperator.Get_SdkAttribute(projectElement);
            return output;
        }

        public string Get_Sdk(XElement projectElement)
        {
            var sdkAttribute = this.Get_SdkAttribute(projectElement);

            var output = Instances.XAttributeOperator.Get_Value(sdkAttribute);
            return output;
        }

        public XElement Append_NewPropertyGroupXElement(XElement projectElement)
        {
            var output = Instances.ProjectXElementsOperator.Append_NewPropertyGroupXElement(projectElement);
            return output;
        }

        public IEnumerable<XElement> Enumerate_PropertyGroupElements(XElement projectElement)
        {
            var output = Instances.XElementOperator.Enumerate_Children(projectElement)
                .Where(element => Instances.XElementOperator.Name_Is(
                    element,
                    Instances.ProjectNodeNames.PropertyGroup))
                ;

            return output;
        }

        public XElement Append_NewItemGroupXElement(XElement projectElement)
        {
            var output = Instances.ProjectXElementsOperator.Append_NewItemGroupXElement(projectElement);
            return output;
        }

        public XElement In_NewPropertyGroupXElementContext(
            XElement projectElement,
            IEnumerable<Action<XElement>> propertyGroupActions)
        {
            var output = Instances.ProjectXElementsOperator.In_NewPropertyGroupXElementContext(
                projectElement,
                propertyGroupActions);

            return output;
        }

        public XElement In_NewItemGroupXElementContext(
            XElement projectElement,
            IEnumerable<Action<XElement>> itemGroupActions)
        {
            var output = Instances.ProjectXElementsOperator.In_NewItemGroupXElementContext(
                projectElement,
                itemGroupActions);

            return output;
        }

        public XElement New_ProjectXElement()
        {
            var output = Instances.ProjectXElementsOperator.New_ProjectXElement();
            return output;
        }

        public XAttribute Set_Sdk(
            XElement projectElement,
            string projectSdkName)
        {
            var output = Instances.ProjectXElementsOperator.Set_Sdk(
                projectElement,
                projectSdkName);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_File_Separated"/> as the default (since this is how Visual Studio saves new project files, although afterwards, Visual Studio respects the file's formatting).
        /// </summary>
        public Task To_File(
            string projectFilePath,
            XElement projectElement)
        {
            return this.To_File_Separated(
                projectFilePath,
                projectElement);
        }

        public Task To_File_Separated(
            string projectFilePath,
            XElement projectElement)
        {
            var separated = this.SeparateGroups(projectElement);

            return Instances.XElementOperator.To_File_AsIs(
                projectFilePath,
                separated);
        }

        public void To_File_Separated_Synchronous(
            string projectFilePath,
            XElement projectElement)
        {
            var separated = this.SeparateGroups(projectElement);

            Instances.XElementOperator.To_File_AsIs_Synchronous(
                projectFilePath,
                separated);
        }

        /// <summary>
        /// Puts a blank line between the group elements of a project element.
        /// This matches the behavior of Visual Studio.
        /// </summary>
        public XElement SeparateGroups(XElement projectElement)
        {
            var output = Instances.XElementOperator._Implementations.Indent(projectElement);

            foreach (var child in Instances.XElementOperator.Enumerate_ChildElements(output))
            {
                if (child.PreviousNode is XText textNode)
                {
                    textNode.Value = Instances.NewLineOperator.Prefix(textNode.Value);
                }
            }

            if (Instances.NullOperator.Is_NotNull(output.LastNode))
            {
                var lastTextNode = output.LastNode as XText;

                lastTextNode.Value = Instances.NewLineOperator.Prefix(lastTextNode.Value);
            }

            return output;
        }
    }
}
