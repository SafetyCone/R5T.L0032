using System;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.L0032.F002
{
    [FunctionalityMarker]
    public partial interface IItemGroupXElementOperator : IFunctionalityMarker,
        F001.IItemGroupXElementOperator
    {
        public XAttribute Set_Label_PackageReferences(XElement propertyGroupElement)
        {
            return this.Set_Label(
                propertyGroupElement,
                Instances.GroupLabels.PackageReferences);
        }

        public XAttribute Set_Label_ProjectReferences(XElement propertyGroupElement)
        {
            return this.Set_Label(
                propertyGroupElement,
                Instances.GroupLabels.ProjectReferences);
        }
    }
}
