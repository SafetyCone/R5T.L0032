using System;
using System.Collections.Generic;
using System.Xml.Linq;

using R5T.T0132;
using R5T.T0206;


namespace R5T.L0032.F004
{
    [FunctionalityMarker]
    public partial interface IItemGroupXElementOperator : IFunctionalityMarker
    {
        public XElement Add_COMReference(
            XElement itemGroupElement,
            COMReference comReference)
        {
            var output = Instances.ProjectXElementsOperator.Add_COMReference(
                itemGroupElement,
                comReference);

            return output;
        }

        public XElement Add_PackageReference(
            XElement itemGroupElement,
            PackageReference packageReference)
        {
            var output = Instances.ProjectXElementsOperator.Add_PackageReference(
                itemGroupElement,
                packageReference);

            return output;
        }

        public XElement Add_ProjectReference(
            XElement itemGroupElement,
            string projectFilePath,
            string referenceProjectFilePath)
        {
            var output = Instances.ProjectXElementsOperator.Add_ProjectReference(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePath);

            return output;
        }

        public XElement Add_ProjectReference(
            XElement itemGroupElement,
            string relativeReferenceProjectFilePath)
        {
            var output = Instances.ProjectXElementsOperator.Add_ProjectReference(
                itemGroupElement,
                relativeReferenceProjectFilePath);

            return output;
        }

        public XElement[] Add_ProjectReferences_ReturnArray(
            XElement itemGroupElement,
            string projectFilePath,
            IEnumerable<string> referenceProjectFilePaths)
        {
            var output = Instances.ProjectXElementsOperator.Add_ProjectReferences_ReturnArray(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths);

            return output;
        }

        public XElement[] Add_ProjectReferences_ReturnArray(
            XElement itemGroupElement,
            string projectFilePath,
            params string[] referenceProjectFilePaths)
        {
            var output = Instances.ProjectXElementsOperator.Add_ProjectReferences_ReturnArray(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths);

            return output;
        }

        public Dictionary<string, XElement> Add_ProjectReferences(
            XElement itemGroupElement,
            string projectFilePath,
            IEnumerable<string> referenceProjectFilePaths)
        {
            var output = Instances.ProjectXElementsOperator.Add_ProjectReferences(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths);

            return output;
        }

        public Dictionary<string, XElement> Add_ProjectReferences(
            XElement itemGroupElement,
            string projectFilePath,
            params string[] referenceProjectFilePaths)
        {
            var output = Instances.ProjectXElementsOperator.Add_ProjectReferences(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths);

            return output;
        }

        public XElement New_ItemGroupXElement()
        {
            var output = Instances.ProjectXElementsOperator.New_ItemGroupXElement();
            return output;
        }

        public XAttribute Set_Label(
            XElement itemGroupElement,
            string label)
        {
            return Instances.ProjectXElementsOperator.Set_Label(
                itemGroupElement,
                label);
        }
    }
}
