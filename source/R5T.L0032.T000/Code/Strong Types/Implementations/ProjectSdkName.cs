using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <inheritdoc cref="IProjectSdkName"/>
    [StrongTypeImplementationMarker]
    public class ProjectSdkName : TypedBase<string>, IStrongTypeImplementationMarker,
        IProjectSdkName
    {
        public ProjectSdkName(string value)
            : base(value)
        {
        }
    }
}
