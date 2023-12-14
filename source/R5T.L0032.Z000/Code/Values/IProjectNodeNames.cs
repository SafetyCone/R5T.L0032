using System;

using R5T.L0030.T000;
using R5T.L0030.T000.Extensions;
using R5T.T0131;

using IElementOrAttributeName = R5T.L0030.T000.N001.IElementName;


namespace R5T.L0032.Z000
{
    /// <summary>
    /// Strongly-typed Visual Studio project file file XML node names.
    /// </summary>
    /// <remarks>
    /// Prior work: R5T.F0020.
    /// </remarks>
    [ValuesMarker]
    public partial interface IProjectNodeNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        /// <summary>
        /// Stringly-typed values.
        /// </summary>
        public Z001.IProjectNodeNames _Platform => Z001.ProjectNodeNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public IElementName Authors => _Platform.Authors.ToElementName();
        public IElementName CheckEolTargetFramework => _Platform.CheckEolTargetFramework.ToElementName();
        public IElementName Company => _Platform.Company.ToElementName();
        public IElementName COMReference => _Platform.COMReference.ToElementName();
        public IElementName Copyright => _Platform.Copyright.ToElementName();
        public IElementName CopyToOutputDirectory => _Platform.CopyToOutputDirectory.ToElementName();
        public IElementName Description => _Platform.Description.ToElementName();
        public IElementName EmbedInteropTypes => _Platform.EmbedInteropTypes.ToElementName();
        public IElementName FrameworkReference => _Platform.FrameworkReference.ToElementName();
        public IElementName GenerateDocumentationFile => _Platform.GenerateDocumentationFile.ToElementName();
        public IElementName Guid => _Platform.Guid.ToElementName();
        public IElementName ImplicitUsings => _Platform.ImplicitUsings.ToElementName();
        public IAttributeName Include => _Platform.Include.ToAttributeName();
        public IElementName Isolated => _Platform.Isolated.ToElementName();
        public IElementName ItemGroup => _Platform.ItemGroup.ToElementName();
        public IAttributeName Label => _Platform.Label.ToAttributeName();
        public IElementName Lcid => _Platform.Lcid.ToElementName();
        public IElementName None => _Platform.None.ToElementName();
        public IElementName NoWarn => _Platform.NoWarn.ToElementName();
        public IElementName Nullable => _Platform.Nullable.ToElementName();
        public IElementName OutputType => _Platform.OutputType.ToElementName();
        public IElementName PackageLicenseExpression => _Platform.PackageLicenseExpression.ToElementName();
        public IElementName PackageReadmeFile => _Platform.PackageReadmeFile.ToElementName();
        public IElementName PackageReference => _Platform.PackageReference.ToElementName();
        public IElementName PackageRequireLicenseAcceptance => _Platform.PackageRequireLicenseAcceptance.ToElementName();
        public IElementName PackageTags => _Platform.PackageTags.ToElementName();
        public IElementName Project => _Platform.Project.ToElementName();
        public IElementName ProjectReference => _Platform.ProjectReference.ToElementName();
        public IElementName PropertyGroup => _Platform.PropertyGroup.ToElementName();
        public IElementName RepositoryUrl => _Platform.RepositoryUrl.ToElementName();
        public IElementName RootNamespace => _Platform.RootNamespace.ToElementName();
        public IAttributeName Sdk => _Platform.Sdk.ToAttributeName();
        public IElementName SupportedPlatform => _Platform.SupportedPlatform.ToElementName();
        public IElementName TargetFramework => _Platform.TargetFramework.ToElementName();
        public IElementName TargetFrameworkVersion => _Platform.TargetFrameworkVersion.ToElementName();
        public IAttributeName Update => _Platform.Update.ToAttributeName();
        public IElementName UseWindowsForms => _Platform.UseWindowsForms.ToElementName();
        public IElementOrAttributeName Version => _Platform.Version.ToElementName_N001();
        public IElementName VersionMinor => _Platform.VersionMinor.ToElementName();
        public IElementName VersionMajor => _Platform.VersionMajor.ToElementName();
        public IElementName WrapperTool => _Platform.WrapperTool.ToElementName();
    }
}
