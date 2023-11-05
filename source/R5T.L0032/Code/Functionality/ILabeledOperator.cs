using System;
using System.Xml.Linq;

using R5T.N0000;

using R5T.L0030.Extensions;
using R5T.T0132;

using R5T.L0032.T000;


namespace R5T.L0032
{
    /// <summary>
    /// Functionality for the <see cref="ILabeled"/> type.
    /// </summary>
    [FunctionalityMarker]
    public partial interface ILabeledOperator : IFunctionalityMarker
    {
        public XAttribute Acquire_LabelAttribute(XElement labeledElement)
        {
            var hasLabelAttribute = this.Has_LabelAttribute(labeledElement);

            var labelAttribute = hasLabelAttribute
                ? hasLabelAttribute.Result
                : this.Add_LabelAttribute(
                    labeledElement)
                ;

            return labelAttribute;
        }

        public XAttribute Add_LabelAttribute(
            XElement element)
        {
            var output = element.Add_Attribute(
                Instances.ProjectElementNames.Label);

            return output;
        }

        public XAttribute Add_LabelAttribute(
            XElement element,
            string value)
        {
            var output = this.Add_LabelAttribute(element);

            Instances.XAttributeOperator.Set_Value(
                output,
                value);

            return output;
        }

        public string Get_Label(ILabeled labeled)
        {
            var hasLabel = this.Has_Label(labeled);

            var output = Instances.WasFoundOperator.ResultOrExceptionIfNotFound(hasLabel);
            return output;
        }

        public bool Is_Label(
            ILabeled labeled,
            string value)
        {
            var label = this.Get_Label(labeled);

            var output = label == value;
            return output;
        }

        public void Set_Label(
            ILabeled labeled,
            string label)
        {
            var labelAttribute = this.Acquire_LabelAttribute(labeled.Value);

            Instances.XAttributeOperator.Set_Value(
                labelAttribute,
                label);
        }

        public WasFound<XAttribute> Has_LabelAttribute(XElement xElement)
        {
            var output = xElement.Has_Attribute(
                Instances.ProjectElementNames.Label);

            return output;
        }

        public WasFound<XAttribute> Has_LabelAttribute(ILabeled labeled)
        {
            var output = this.Has_LabelAttribute(labeled.Value);
            return output;
        }

        public WasFound<string> Has_Label(ILabeled labeled)
        {
            var hasLabelAttribute = this.Has_LabelAttribute(labeled);

            var output = hasLabelAttribute.Convert(
                Instances.XAttributeOperator.Get_Value);

            return output;
        }

        public bool Has_LabelValue(
            ILabeled labeled,
            string value)
        {
            var hasLabel = this.Has_Label(labeled);

            var output = hasLabel.Exists && hasLabel.Result == value;
            return output;
        }
    }
}
