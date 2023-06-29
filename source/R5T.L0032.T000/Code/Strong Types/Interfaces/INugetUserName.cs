using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a string as a user name on <see href="https://www.nuget.org"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface INugetUserName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
