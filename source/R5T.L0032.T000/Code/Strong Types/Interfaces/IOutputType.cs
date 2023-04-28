using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly-types a string as the output type of a Visual Studio project file.
    /// See "outputtype" in <see href="https://learn.microsoft.com/en-us/visualstudio/msbuild/common-msbuild-project-properties?view=vs-2022#list-of-common-properties-and-parameters"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IOutputType : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
