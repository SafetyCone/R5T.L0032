using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// The URL of a repository.
    /// </summary>
    [StrongTypeMarker]
    public interface IRepositoryUrl : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
