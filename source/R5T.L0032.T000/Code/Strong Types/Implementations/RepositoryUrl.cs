using System;

using R5T.T0178;
using R5T.T0179;
using R5T.T0198;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="IRepositoryUrl"/>
    [StrongTypeImplementationMarker]
    public class RepositoryUrl : TypedBase<string>, IStrongTypeImplementationMarker,
        IRepositoryUrl
    {
        public RepositoryUrl(string value)
            : base(value)
        {
        }
    }
}
