using System;
using System.Xml.Linq;


namespace R5T.L0032.T000.Extensions
{
    public static class XElementExtensions
    {
        public static ICOMReferenceElement ToCOMReferenceElement(this XElement value)
        {
            return Instances.XElementOperator.ToCOMReferenceElement(value);
        }

        public static ICOMReferenceItemGroupElement ToCOMReferenceItemGroupElement(this XElement value)
        {
            return Instances.XElementOperator.ToCOMReferenceItemGroupElement(value);
        }

        public static ICopyToOutputItemGroupElement ToCopyToOutputItemGroupElement(this XElement value)
        {
            return Instances.XElementOperator.ToCopyToOutputItemGroupElement(value);
        }

        public static ICopyToOutputElement ToCopyToOutputElement(this XElement value)
        {
            return Instances.XElementOperator.ToCopyToOutputElement(value);
        }

        public static IMainPropertyGroupElement ToMainPropertyGroupElement(this XElement value)
        {
            return Instances.XElementOperator.ToMainPropertyGroupElement(value);
        }

        public static IPackagePropertyGroupElement ToPackagePropertyGroupElement(this XElement value)
        {
            return Instances.XElementOperator.ToPackagePropertyGroupElement(value);
        }

        public static IPackageReferenceItemGroupElement ToPackageReferenceItemGroupElement(this XElement value)
        {
            return Instances.XElementOperator.ToPackageReferenceItemGroupElement(value);
        }

        public static IPackageReferenceElement ToPackageReferenceElement(this XElement value)
        {
            return Instances.XElementOperator.ToPackageReferenceElement(value);
        }

        public static IProjectElement ToProjectElement(this XElement value)
        {
            return Instances.XElementOperator.ToProjectElement(value);
        }

        public static IProjectReferenceItemGroupElement ToProjectReferenceItemGroupElement(this XElement value)
        {
            return Instances.XElementOperator.ToProjectReferenceItemGroupElement(value);
        }

        public static IProjectReferenceElement ToProjectReferenceElement(this XElement value)
        {
            return Instances.XElementOperator.ToProjectReferenceElement(value);
        }

        public static IPropertyGroupElement ToPropertyGroupElement(this XElement value)
        {
            return Instances.XElementOperator.ToPropertyGroupElement(value);
        }

        public static IItemGroupElement ToItemGroupElement(this XElement value)
        {
            return Instances.XElementOperator.ToItemGroupElement(value);
        }
    }
}
