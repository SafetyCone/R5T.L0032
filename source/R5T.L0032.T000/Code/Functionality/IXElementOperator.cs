using System;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.L0032.T000
{
    [FunctionalityMarker]
    public partial interface IXElementOperator : IFunctionalityMarker
    {
        public ICOMReferenceElement ToCOMReferenceElement(XElement value)
        {
            var output = new COMReferenceElement(value);
            return output;
        }

        public ICOMReferenceItemGroupElement ToCOMReferenceItemGroupElement(XElement value)
        {
            var output = new COMReferenceItemGroupElement(value);
            return output;
        }

        public ICopyToOutputItemGroupElement ToCopyToOutputItemGroupElement(XElement value)
        {
            var output = new CopyToOutputItemGroupElement(value);
            return output;
        }

        public ICopyToOutputElement ToCopyToOutputElement(XElement value)
        {
            var output = new CopyToOutputElement(value);
            return output;
        }

        public IMainPropertyGroupElement ToMainPropertyGroupElement(XElement value)
        {
            var output = new MainPropertyGroupElement(value);
            return output;
        }

        public IPackagePropertyGroupElement ToPackagePropertyGroupElement(XElement value)
        {
            var output = new PackagePropertyGroupElement(value);
            return output;
        }

        public IPackageReferenceItemGroupElement ToPackageReferenceItemGroupElement(XElement value)
        {
            var output = new PackageReferenceItemGroupElement(value);
            return output;
        }

        public IPackageReferenceElement ToPackageReferenceElement(XElement value)
        {
            var output = new PackageReferenceElement(value);
            return output;
        }

        public IProjectElement ToProjectElement(XElement value)
        {
            var output = new ProjectElement(value);
            return output;
        }

        public IProjectReferenceItemGroupElement ToProjectReferenceItemGroupElement(XElement value)
        {
            var output = new ProjectReferenceItemGroupElement(value);
            return output;
        }

        public IProjectReferenceElement ToProjectReferenceElement(XElement value)
        {
            var output = new ProjectReferenceElement(value);
            return output;
        }

        public IPropertyGroupElement ToPropertyGroupElement(XElement value)
        {
            var output = new PropertyGroupElement(value);
            return output;
        }

        public IItemGroupElement ToItemGroupElement(XElement value)
        {
            var output = new ItemGroupElement(value);
            return output;
        }
    }
}
