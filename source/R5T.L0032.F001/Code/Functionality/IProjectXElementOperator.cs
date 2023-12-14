using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
    public partial interface IProjectXElementOperator : IFunctionalityMarker
    {
        public XAttribute Acquire_SdkAttribute(XElement projectElement)
        {
            var sdkAttribute = Instances.XElementOperator.Acquire_Attribute(
                projectElement,
                Instances.ProjectNodeNames._Platform.Sdk);

            return sdkAttribute;
        }

        public XElement Append_NewPropertyGroupXElement(XElement projectElement)
        {
            var propertyGroupXElement = Instances.XElementOperator.Append_Child(
                projectElement,
                Instances.PropertyGroupXElementOperator.New_PropertyGroupXElement);

            return propertyGroupXElement;
        }

        public XElement Append_NewItemGroupXElement(XElement projectElement)
        {
            var propertyGroupXElement = Instances.XElementOperator.Append_Child(
                projectElement,
                Instances.ItemGroupXElementOperator.New_ItemGroupXElement);

            return propertyGroupXElement;
        }

        public XElement In_NewPropertyGroupXElementContext(
            XElement projectElement,
            IEnumerable<Action<XElement>> propertyGroupActions)
        {
            var propertyGroupXElement = this.Append_NewPropertyGroupXElement(projectElement);

            Instances.ContextOperator.In_Context(
                propertyGroupXElement,
                propertyGroupActions);

            return propertyGroupXElement;
        }

        public XElement In_NewItemGroupXElementContext(
            XElement projectElement,
            IEnumerable<Action<XElement>> itemGroupActions)
        {
            var propertyGroupXElement = this.Append_NewItemGroupXElement(projectElement);

            Instances.ContextOperator.In_Context(
                propertyGroupXElement,
                itemGroupActions);

            return propertyGroupXElement;
        }

        public XElement New_ProjectXElement()
        {
            var projectElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames._Platform.Project);

            return projectElement;
        }

        public XAttribute Set_Sdk(
            XElement projectElement,
            IProjectSdkName projectSdkName)
        {
            var sdkAttribute = this.Acquire_SdkAttribute(projectElement);

            sdkAttribute.Value = projectSdkName.Value;

            return sdkAttribute;
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
            var separated = this.Separate(projectElement);

            return Instances.XElementOperator.To_File_AsIs(
                projectFilePath,
                separated);
        }

        public void To_File_Separated_Synchronous(
            string projectFilePath,
            XElement projectElement)
        {
            var separated = this.Separate(projectElement);

            Instances.XElementOperator.To_File_AsIs_Synchronous(
                projectFilePath,
                separated);
        }

        public void To_File_Separated_Synchronous(
            IProjectFilePath projectFilePath,
            IProjectElement projectElement)
        {
            this.To_File_Separated_Synchronous(
                projectFilePath.Value,
                projectElement.Value);
        }

        public XElement Separate(XElement projectElement)
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
