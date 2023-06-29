using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0032.T000.N001
{
    /// <summary>
    /// Strongly types a <see cref="XElement"/> as being an element (any type of element) of a .NET (MSBuild) project file.
    /// This is the base type for all project element types.
    /// <para><inheritdoc cref="Documentation.ProjectFileSchemaLink" path="/summary"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectElement : IStrongTypeMarker,
        ITyped<XElement>
    {
    }
}
