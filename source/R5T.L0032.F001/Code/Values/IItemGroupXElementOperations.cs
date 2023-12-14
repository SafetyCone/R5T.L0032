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
            propertyGroupElement => Instances.ItemGroupXElementOperator.Add_COMReference(
                propertyGroupElement,
                comReference);

        public Action<XElement> Add_ProjectReference(
            string projectFilePath,
            string referenceProjectFilePath) =>
            propertyGroupElement => Instances.ItemGroupXElementOperator.Add_ProjectReference(
                propertyGroupElement,
                projectFilePath,
                referenceProjectFilePath);

        public Action<XElement> Add_ProjectReferences(
            string projectFilePath,
            IEnumerable<string> referenceProjectFilePaths) =>
            propertyGroupElement => Instances.ItemGroupXElementOperator.Add_ProjectReferences(
                propertyGroupElement,
                projectFilePath,
                referenceProjectFilePaths);

        public Action<XElement> Add_ProjectReferences(
            string projectFilePath,
            params string[] referenceProjectFilePaths) =>
            propertyGroupElement => Instances.ItemGroupXElementOperator.Add_ProjectReferences(
                propertyGroupElement,
                projectFilePath,
                referenceProjectFilePaths);

        public Action<XElement> Set_Label(string label) =>
            propertyGroupElement => Instances.ItemGroupXElementOperator.Set_Label(
                propertyGroupElement,
                label);

        public Action<XElement> Set_Label(IGroupLabel groupLabel) =>
            propertyGroupElement => Instances.ItemGroupXElementOperator.Set_Label(
                propertyGroupElement,
                groupLabel);
    }
}
