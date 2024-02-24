using System;
using System.Xml.Linq;

using R5T.T0132;
using R5T.T0218;
using R5T.T0221;

using R5T.L0032.T000;


namespace R5T.L0032.F001
{
    [FunctionalityMarker]
    public partial interface IPropertyGroupXElementOperator : IFunctionalityMarker,
        F004.IPropertyGroupXElementOperator
    {
        public XElement Set_ImplicitUsings(
            XElement propertyGroupElement,
            Enabled enabled)
        {
            var implicitUsingsValue = Instances.EnabledOperator.To_String(enabled);

            return this.Set_ImplicitUsings(
                propertyGroupElement,
                implicitUsingsValue);
        }

        public XAttribute Set_Label(
            XElement propertyGroupElement,
            IGroupLabel groupLabel)
        {
            return Instances.ProjectXElementsOperator.Set_Label(
                propertyGroupElement,
                groupLabel);
        }

        public XElement Set_Nullable(
            XElement propertyGroupElement,
            T000.Nullable nullable)
        {
            var nullableValue = Instances.NullableOperator.To_String(nullable);

            return this.Set_Nullable(
                propertyGroupElement,
                nullableValue);
        }

        public XElement Set_OutputType(
            XElement propertyGroupElement,
            IOutputType outputType)
        {
            return this.Set_OutputType(
                propertyGroupElement,
                outputType.Value);
        }

        public XElement Set_OutputType_Exe(XElement propertyGroupElement)
        {
            return this.Set_OutputType(
                propertyGroupElement,
                Instances.OutputTypes.Exe);
        }

        public XElement Set_OutputType_Library(XElement propertyGroupElement)
        {
            return this.Set_OutputType(
                propertyGroupElement,
                Instances.OutputTypes.Library);
        }

        public XElement Set_TargetFramework(
            XElement propertyGroupElement,
            ITargetFrameworkMoniker targetFrameworkMoniker)
        {
            return this.Set_TargetFramework(
                propertyGroupElement,
                targetFrameworkMoniker.Value);
        }
    }
}
