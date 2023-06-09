﻿using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="INugetUserName"/>
    [StrongTypeImplementationMarker]
    public class NugetUserName : TypedBase<string>, IStrongTypeImplementationMarker,
        INugetUserName
    {
        public NugetUserName(string value)
            : base(value)
        {
        }
    }
}
