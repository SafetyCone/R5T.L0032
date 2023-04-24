using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    [StrongTypeImplementationMarker]
    public class GroupLabel : TypedBase<string>, IStrongTypeImplementationMarker,
        IGroupLabel
    {
        public GroupLabel(string value)
            : base(value)
        {
        }
    }
}
