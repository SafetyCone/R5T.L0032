using System;

using R5T.T0178;


namespace R5T.L0032.T000
{
    /// <summary>
    /// <para>See: <see href="https://learn.microsoft.com/en-us/visualstudio/msbuild/itemgroup-element-msbuild?view=vs-2022"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IItemGroupElement : IStrongTypeMarker,
        N001.IProjectElement,
        ILabeled
    {
    }
}
