using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="ICopyToOutputDirective"/>
    [StrongTypeImplementationMarker]
    public class CopyToOutputDirective : TypedBase<string>, IStrongTypeImplementationMarker,
        ICopyToOutputDirective
    {
        public CopyToOutputDirective(string value)
            : base(value)
        {
        }
    }
}
