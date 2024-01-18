using System;
using System.Xml.Linq;

using R5T.T0132;

using R5T.L0032.T000;


namespace R5T.L0032.F001
{
    /// <summary>
    /// Operator for XElements in the Visual Studio project XElement schema.
    /// Note: not just for the project XElement (see <see cref="ProjectXElementOperator"/> for just the project XElement).
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectXElementsOperator : IFunctionalityMarker,
        F004.IProjectXElementsOperator
    {
        public XAttribute Set_Label(
            XElement groupElement,
            IGroupLabel groupLabel)
        {
            return this.Set_Label(
                groupElement,
                groupLabel.Value);
        }
    }
}
