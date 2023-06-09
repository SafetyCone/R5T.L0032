﻿
using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="ITargetFrameworkMoniker"/>
    [StrongTypeImplementationMarker]
    [Obsolete("Use R5T.T0218.ITargetFrameworkMoniker instead.")]
    public class TargetFrameworkMoniker : TypedBase<string>, IStrongTypeImplementationMarker,
        ITargetFrameworkMoniker
    {
        public TargetFrameworkMoniker(string value)
            : base(value)
        {
        }
    }
}
