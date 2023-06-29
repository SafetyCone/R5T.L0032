using System;
using System.Xml.Linq;

using R5T.T0178;


namespace R5T.L0032.T000
{
    /// <summary>
    /// Strongly types a <see cref="XElement"/> as the project element (root element) of a .NET (MSBuild) project file.
    /// <para><inheritdoc cref="Documentation.ProjectFileSchemaLink" path="/summary"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectElement : IStrongTypeMarker,
        N001.IProjectElement
    {
    }
}
