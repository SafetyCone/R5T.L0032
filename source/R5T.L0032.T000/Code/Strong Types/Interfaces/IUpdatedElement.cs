using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// An element with an "Update" attribute.
    /// </summary>
    [StrongTypeMarker]
    public interface IUpdatedElement : IStrongTypeMarker,
        ITyped<XElement>
    {
    }
}
