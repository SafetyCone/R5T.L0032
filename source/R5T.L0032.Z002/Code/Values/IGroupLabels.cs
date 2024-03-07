using System;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;
using R5T.T0131;


namespace R5T.L0032.Z002
{
    /// <summary>
    /// Group labels allow labeling specific sections of the project element.
    /// </summary>
    /// <remarks>
    /// Group labels are Rivet-specific.
    /// </remarks>
    [ValuesMarker]
    public partial interface IGroupLabels : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IGroupLabels _Platform => Platform.GroupLabels.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public IGroupLabel COMReferences => _Platform.COMReferences.ToGroupLabel();
        public IGroupLabel CopyToOutput => _Platform.CopyToOutput.ToGroupLabel();
        public IGroupLabel Custom => _Platform.Custom.ToGroupLabel();
        public IGroupLabel Main => _Platform.Main.ToGroupLabel();
        public IGroupLabel Package => _Platform.Package.ToGroupLabel();

        /// <inheritdoc cref="Platform.IGroupLabels.PackageReferences"/>
        public IGroupLabel PackageReferences => _Platform.PackageReferences.ToGroupLabel();

        /// <inheritdoc cref="Platform.IGroupLabels.ProjectReferences"/>
        public IGroupLabel ProjectReferences => _Platform.ProjectReferences.ToGroupLabel();
    }
}
