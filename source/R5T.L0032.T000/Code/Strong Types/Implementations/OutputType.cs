
using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="IOutputType"/>
    [StrongTypeImplementationMarker]
    public class OutputType : TypedBase<string>, IStrongTypeImplementationMarker,
        IOutputType
    {
        public OutputType(string value)
            : base(value)
        {
        }
    }
}
