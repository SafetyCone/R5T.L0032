using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    [StrongTypeMarker]
    public interface IProjectDocument : IStrongTypeMarker,
        ITyped<XDocument>
    {
    }
}
