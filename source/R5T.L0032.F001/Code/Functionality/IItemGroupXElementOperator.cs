using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using R5T.T0132;
using R5T.T0206;

using R5T.L0032.T000;


namespace R5T.L0032.F001
{
    [FunctionalityMarker]
    public partial interface IItemGroupXElementOperator : IFunctionalityMarker
    {
        public XElement Add_COMReference(
            XElement itemGroupElement,
            COMReference comReference)
        {
            var comReferenceElement = Instances.ProjectXElementsOperator.Get_COMReferenceElement(comReference);

            Instances.XElementOperator.Add_Child(
                itemGroupElement,
                comReferenceElement);

            return comReferenceElement;
        }

        public XElement[] Add_ProjectReferences(
            XElement itemGroupElement,
            string projectFilePath,
            IEnumerable<string> referenceProjectFilePaths)
        {
            var relativeReferenceProjectFilePaths = Instances.ProjectPathsOperator.Get_RelativeReferenceProjectFilePaths(
                projectFilePath,
                referenceProjectFilePaths);

            var output = relativeReferenceProjectFilePaths
                .Select(relativeReferenceProjectFilePath => this.Add_ProjectReference(
                    itemGroupElement,
                    relativeReferenceProjectFilePath))
                .Now();

            return output;
        }

        public XElement[] Add_ProjectReferences(
            XElement itemGroupElement,
            string projectFilePath,
            params string[] referenceProjectFilePaths)
        {
            return this.Add_ProjectReferences(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths.AsEnumerable());
        }

        public XElement Add_ProjectReference(
            XElement itemGroupElement,
            string projectFilePath,
            string referenceProjectFilePath)
        {
            var relativeReferenceProjectFilePath = Instances.ProjectPathsOperator.Get_RelativeReferenceProjectFilePath(
                projectFilePath,
                referenceProjectFilePath);

            var output = this.Add_ProjectReference(
                itemGroupElement,
                relativeReferenceProjectFilePath);

            return output;
        }

        public XElement Add_ProjectReference(
            XElement itemGroupElement,
            string relativeReferenceProjectFilePath)
        {
            var projectReferenceElement = Instances.ProjectXElementsOperator.New_ProjectReferenceXElement(relativeReferenceProjectFilePath);

            Instances.XElementOperator.Add(
                itemGroupElement,
                projectReferenceElement);

            return projectReferenceElement;
        }

        public XElement New_ItemGroupXElement()
        {
            var propertyGroupElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames._Platform.ItemGroup);

            return propertyGroupElement;
        }

        public XAttribute Set_Label(
            XElement itemGroupElement,
            string label)
        {
            return Instances.ProjectXElementsOperator.Set_Label(
                itemGroupElement,
                label);
        }

        public XAttribute Set_Label(
            XElement itemGroupElement,
            IGroupLabel groupLabel)
        {
            return Instances.ProjectXElementsOperator.Set_Label(
                itemGroupElement,
                groupLabel);
        }
    }
}
