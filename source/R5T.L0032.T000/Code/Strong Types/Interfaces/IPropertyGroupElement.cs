using System;

using R5T.T0178;


namespace R5T.L0032.T000
{
    /// <summary>
    /// See: <see href="https://learn.microsoft.com/en-us/visualstudio/msbuild/propertygroup-element-msbuild?view=vs-2022"/>
    /// </summary>
    [StrongTypeMarker]
    public interface IPropertyGroupElement : IStrongTypeMarker,
        N001.IProjectElement,
        ILabeled
    {
    }
}
