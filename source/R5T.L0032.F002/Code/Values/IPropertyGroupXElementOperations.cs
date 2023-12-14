using System;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.L0032.F002
{
    /// <summary>
    /// Rivet-specific property group XElement operations.
    /// </summary>
    [ValuesMarker]
    public partial interface IPropertyGroupXElementOperations : IValuesMarker,
        F001.IPropertyGroupXElementOperations
    {
        public Action<XElement> Set_Company_Rivet =>
            this.Set_Company(Instances.CompanyNames.Rivet.Value);

        public Action<XElement> Set_Copyright_Rivet =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Copyright_Rivet(propertyGroupElement);

        public Action<XElement> Set_Label_Main =>
            this.Set_Label(Instances.GroupLabels.Main);

        public Action<XElement> Set_Label_Package =>
            this.Set_Label(Instances.GroupLabels.Package);
    }
}
