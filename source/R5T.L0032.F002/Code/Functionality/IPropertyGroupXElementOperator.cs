using System;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.L0032.F002
{
    [FunctionalityMarker]
    public partial interface IPropertyGroupXElementOperator : IFunctionalityMarker,
        F001.IPropertyGroupXElementOperator
    {
        public XElement Set_Copyright_Rivet(XElement propertyGroupElement)
        {
            var copyright = Instances.CopyrightOperator.Get_CopyrightText(
                Instances.CompanyNames.Rivet.Value);

            return this.Set_Copyright(
                propertyGroupElement,
                copyright);
        }

        public XAttribute Set_Label_Main(XElement propertyGroupElement)
        {
            return this.Set_Label(
                propertyGroupElement,
                Instances.GroupLabels.Main);
        }

        public XAttribute Set_Label_Package(XElement propertyGroupElement)
        {
            return this.Set_Label(
                propertyGroupElement,
                Instances.GroupLabels.Package);
        }
    }
}
