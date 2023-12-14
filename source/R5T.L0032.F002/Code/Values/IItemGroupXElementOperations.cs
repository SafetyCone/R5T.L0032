using System;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.L0032.F002
{
    [ValuesMarker]
    public partial interface IItemGroupXElementOperations : IValuesMarker,
        F001.IItemGroupXElementOperations
    {
        public Action<XElement> Set_Label_COMReferences =>
            this.Set_Label(Instances.GroupLabels.COMReferences);

        public Action<XElement> Set_Label_ProjectReferences =>
            this.Set_Label(Instances.GroupLabels.ProjectReferences);
    }
}
