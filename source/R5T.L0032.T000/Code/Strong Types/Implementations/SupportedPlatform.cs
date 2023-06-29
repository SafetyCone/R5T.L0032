using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="ISupportedPlatform"/>
    [StrongTypeImplementationMarker]
    public class SupportedPlatform : TypedBase<string>, IStrongTypeMarker,
        ISupportedPlatform
    {
        public SupportedPlatform(string value)
            : base(value)
        {
        }
    }
}