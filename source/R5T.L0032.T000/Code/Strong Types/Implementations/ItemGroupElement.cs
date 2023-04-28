using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.L0032.T000
{
    /// <see cref="IItemGroupElement"/>
    [StrongTypeImplementationMarker]
    public class ItemGroupElement : TypedBase<XElement>, IStrongTypeImplementationMarker,
        IItemGroupElement
    {
        public ItemGroupElement(XElement value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(XElement a, XElement b)
        {
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(XElement a, XElement b)
        {
            throw new NotImplementedException();
        }
    }
}
