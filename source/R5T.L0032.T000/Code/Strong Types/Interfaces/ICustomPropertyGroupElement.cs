using System;

using R5T.T0178;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a <see cref="System.Xml.XmlElement"/> as a custom property group element.
    /// </summary>
    [StrongTypeMarker]
    public interface ICustomPropertyGroupElement : IStrongTypeMarker,
        IPropertyGroupElement
    {
    }
}
