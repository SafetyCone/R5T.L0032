using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a string as the value for a property or item group label.
    /// </summary>
    [StrongTypeMarker]
    public interface IGroupLabel : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
