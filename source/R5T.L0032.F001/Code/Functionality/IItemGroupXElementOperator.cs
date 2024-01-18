using System;
using System.Xml.Linq;

using R5T.T0132;

using R5T.L0032.T000;


namespace R5T.L0032.F001
{
    [FunctionalityMarker]
    public partial interface IItemGroupXElementOperator : IFunctionalityMarker,
        F004.IItemGroupXElementOperator
    {
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
