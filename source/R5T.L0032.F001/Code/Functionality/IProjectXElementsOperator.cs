using System;
using System.Xml.Linq;

using R5T.T0132;
using R5T.T0206;

using R5T.L0032.F003.Extensions;
using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.F001
{
    /// <summary>
    /// Operator for XElements in the Visual Studio project XElement schema.
    /// Note: not just for the project XElement (see <see cref="ProjectXElementOperator"/> for just the project XElement).
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectXElementsOperator : IFunctionalityMarker
    {
        public XAttribute Acquire_IncludeAttribute(XElement includedElement)
        {
            var includeAttribute = Instances.XElementOperator.Acquire_Attribute(
                includedElement,
                Instances.ProjectNodeNames._Platform.Include);

            return includeAttribute;
        }

        public XAttribute Acquire_LabelAttribute(XElement labeledElement)
        {
            var labelAttribute = Instances.XElementOperator.Acquire_Attribute(
                labeledElement,
                Instances.ProjectNodeNames._Platform.Label);

            return labelAttribute;
        }

        public XAttribute Add_LabelAttribute(
            XElement element)
        {
            var output = Instances.XElementOperator.Add_Attribute(
                element,
                Instances.ProjectNodeNames._Platform.Label);

            return output;
        }

        public XAttribute Add_LabelAttribute(
            XElement element,
            string value)
        {
            var output = this.Add_LabelAttribute(element);

            Instances.XAttributeOperator.Set_Value(
                output,
                value);

            return output;
        }
        public XElement Get_COMReferenceElement(COMReference comReference)
        {
            var comReferenceElement = this.New_COMReferenceXElement();

            this.Set_Include(
                comReferenceElement,
                comReference.Name);

            var comReferenceProperties = new[]
            {
                Instances.XElementOperator.New(Instances.ProjectNodeNames.WrapperTool.Value, comReference.WrapperTool),
                Instances.XElementOperator.New(Instances.ProjectNodeNames.VersionMinor.Value, comReference.Version_Minor.To_String_ForProjectXml()),
                Instances.XElementOperator.New(Instances.ProjectNodeNames.VersionMajor.Value, comReference.Version_Major.To_String_ForProjectXml()),
                Instances.XElementOperator.New(Instances.ProjectNodeNames.Guid.Value, comReference.Guid.To_String_ForCOMReference()),
                Instances.XElementOperator.New(Instances.ProjectNodeNames.Lcid.Value, comReference.Lcid.To_String_ForProjectXml()),
                Instances.XElementOperator.New(Instances.ProjectNodeNames.Isolated.Value, comReference.Isolated.To_String_ForProjectXml()),
                Instances.XElementOperator.New(Instances.ProjectNodeNames.EmbedInteropTypes.Value, comReference.EmbedInteropTypes.To_String_ForProjectXml())
            };

            Instances.XElementOperator.Add_Children(
                comReferenceElement,
                comReferenceProperties);

            return comReferenceElement;
        }

        public bool Has_LabelAttribute(
            XElement element,
            out XAttribute labelAttributeOrDefault)
        {
            var output = Instances.XElementOperator.Has_Attribute(
                element,
                Instances.ProjectNodeNames._Platform.Label,
                out labelAttributeOrDefault);

            return output;
        }

        public XElement New_COMReferenceXElement()
        {
            var comReferenceElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.COMReference.Value);

            return comReferenceElement;
        }

        public XElement New_ProjectReferenceXElement()
        {
            var output = Instances.XElementOperator.New(
                Instances.ProjectNodeNames._Platform.ProjectReference);

            return output;
        }

        public XElement New_ProjectReferenceXElement(
            string projectFilePath,
            string referenceProjectFilePath)
        {
            var relativeReferenceProjectFilePath = Instances.ProjectPathsOperator.Get_RelativeReferenceProjectFilePath(
                projectFilePath,
                referenceProjectFilePath);

            var projectReferenceElement = this.New_ProjectReferenceXElement(relativeReferenceProjectFilePath);
            return projectReferenceElement;
        }

        public XElement New_ProjectReferenceXElement(
            string relativeReferenceProjectFilePath)
        {
            var projectReferenceElement = this.New_ProjectReferenceXElement();

            // Ignore returned attribute.
            Instances.ProjectXElementsOperator.Set_Include(
                projectReferenceElement,
                relativeReferenceProjectFilePath);

            return projectReferenceElement;
        }

        public XAttribute Set_Include(
            XElement groupElement,
            string value)
        {
            var includeAttribute = this.Acquire_IncludeAttribute(groupElement);

            Instances.XAttributeOperator.Set_Value(
                includeAttribute,
                value);

            return includeAttribute;
        }

        public XAttribute Set_Label(
            XElement groupElement,
            string label)
        {
            var labelAttribute = this.Acquire_LabelAttribute(groupElement);

            Instances.XAttributeOperator.Set_Value(
                labelAttribute,
                label);

            return labelAttribute;
        }

        public XAttribute Set_Label(
            XElement groupElement,
            IGroupLabel groupLabel)
        {
            return this.Set_Label(
                groupElement,
                groupLabel.Value);
        }

        public void Set_Version(
            XElement versionElement,
            string versionString)
        {
            versionElement.Value = versionString;
        }

        public void Set_Version(
            XElement versionElement,
            Version version)
        {
            var versionString = Instances.VersionOperator.ToString_ForProjectXml(version);

            this.Set_Version(
                versionElement,
                versionString);
        }
    }
}
