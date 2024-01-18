using System;
using System.Collections.Generic;
using System.Xml.Linq;

using R5T.T0131;
using R5T.T0206;

using R5T.L0032.T000;


namespace R5T.L0032.F001
{
    [ValuesMarker]
    public partial interface IItemGroupXElementOperations : IValuesMarker
    {
        public Action<XElement> Add_COMReference(COMReference comReference) =>
            itemGroupElement => Instances.ItemGroupXElementOperator.Add_COMReference(
                itemGroupElement,
                comReference);

        public Action<XElement> Add_PackageReference(
            PackageReference packageReference) =>
            itemGroupElement => Instances.ItemGroupXElementOperator.Add_PackageReference(
                itemGroupElement,
                packageReference);

        public Action<XElement> Add_ProjectReference(
            string projectFilePath,
            string referenceProjectFilePath) =>
            itemGroupElement => Instances.ItemGroupXElementOperator.Add_ProjectReference(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePath);

        public Action<XElement> Add_ProjectReferences(
            string projectFilePath,
            IEnumerable<string> referenceProjectFilePaths) =>
            itemGroupElement => Instances.ItemGroupXElementOperator.Add_ProjectReferences(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths);

        public Action<XElement> Add_ProjectReferences(
            string projectFilePath,
            params string[] referenceProjectFilePaths) =>
            itemGroupElement => Instances.ItemGroupXElementOperator.Add_ProjectReferences(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths);

        public Action<XElement> Set_Label(string label) =>
            itemGroupElement => Instances.ItemGroupXElementOperator.Set_Label(
                itemGroupElement,
                label);

        public Action<XElement> Set_Label(IGroupLabel groupLabel) =>
            itemGroupElement => Instances.ItemGroupXElementOperator.Set_Label(
                itemGroupElement,
                groupLabel);
    }
}
