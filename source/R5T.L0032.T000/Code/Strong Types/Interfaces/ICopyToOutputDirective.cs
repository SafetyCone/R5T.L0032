using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// The value for the copy-to-output directory element.
    /// </summary>
    [StrongTypeMarker]
    public interface ICopyToOutputDirective : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
