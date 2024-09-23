using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.L0032.Z001
{
    /// <summary>
    /// Platform-typed Visual Studio project element node name values.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectNodeNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IProjectNodeNames _Raw => Raw.ProjectNodeNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>Name</value></para>
        /// Common - used by MSBuild.
        /// </summary>
        public string AssemblyName => "AssemblyName";

        public string Authors => "Authors";
        public string CheckEolTargetFramework => "CheckEolTargetFramework";
        public string Company => "Company";
        public string COMReference => "COMReference";

        /// <summary>
        /// <para><value>Content</value></para>
        /// </summary>
        public string Content => "Content";

        public string Copyright => "Copyright";

        /// <summary>
        /// <para><value>CopyToOutputDirectory</value></para>
        /// </summary>
        public string CopyToOutputDirectory => "CopyToOutputDirectory";

        /// <summary>
        /// <para><value>CopyToPublishDirectory</value></para>
        /// </summary>
        public string CopyToPublishDirectory => "CopyToPublishDirectory";

        /// <summary>
        /// Rivet-specific element.
        /// <para><value>Description</value></para>
        /// </summary>
        public string Description => "Description";

        public string EmbedInteropTypes => "EmbedInteropTypes";
        public string FrameworkReference => "FrameworkReference";

        /// <summary>
        /// <para><value>Folder</value></para>
        /// </summary>
        public string Folder => "Folder";
        public string GenerateDocumentationFile => "GenerateDocumentationFile";
        public string Guid => "Guid";
        public string ImplicitUsings => "ImplicitUsings";
        public string Include => "Include";
        public string Isolated => "Isolated";
        public string ItemGroup => "ItemGroup";
        public string Label => "Label";
        public string Lcid => "Lcid";

        /// <summary>
        /// Rivet-specific element.
        /// <para><value>Name</value></para>
        /// </summary>
        public string Name => "Name";

        /// <summary>
        /// <para><value>NoDefaultLaunchSettingsFile</value></para>
        /// </summary>
        public string NoDefaultLaunchSettingsFile => "NoDefaultLaunchSettingsFile";

        public string None => "None";
        public string NoWarn => "NoWarn";
        public string Nullable => "Nullable";
        public string OutputType => "OutputType";

        /// <summary>
        /// <para><value>PackageDescription</value></para>
        /// Common - 
        /// </summary>
        public string PackageDescription => "PackageDescription";

        /// <summary>
        /// <para><value>PackageId</value></para>
        /// Common - used by NuGet.
        /// </summary>
        public string PackageId => "PackageId";

        public string PackageLicenseExpression => "PackageLicenseExpression";
        public string PackageReadmeFile => "PackageReadmeFile";
        public string PackageReference => "PackageReference";
        public string PackageRequireLicenseAcceptance => "PackageRequireLicenseAcceptance";
        public string PackageTags => "PackageTags";

        /// <summary>
        /// <para><value>Project</value></para>
        /// The name of the root element of a .NET project file.
        /// </summary>
        public string Project => "Project";
        public string ProjectReference => "ProjectReference";
        public string PropertyGroup => "PropertyGroup";
        public string RepositoryUrl => "RepositoryUrl";
        public string RootNamespace => "RootNamespace";

        /// <summary>
        /// <para><value>Sdk</value></para>
        /// </summary>
        public string Sdk => "Sdk";

        /// <summary>
        /// <para><value>StaticWebAssetProjectMode</value></para>
        /// </summary>
        public string StaticWebAssetProjectMode => "StaticWebAssetProjectMode";

        /// <summary>
        /// <para><value>SupportedPlatform</value></para>
        /// </summary>
        public string SupportedPlatform => "SupportedPlatform";
        public string TargetFramework => "TargetFramework";
        public string TargetFrameworkVersion => "TargetFrameworkVersion";
        public string Update => "Update";
        public string UseWindowsForms => "UseWindowsForms";
        public string Version => "Version";
        public string VersionMinor => "VersionMinor";
        public string VersionMajor => "VersionMajor";

        /// <summary>
        /// <para><value>WasmEnableWebcil</value></para>
        /// </summary>
        public string WasmEnableWebcil => "WasmEnableWebcil";

        /// <summary>
        /// <para><value>WrapperTool</value></para>
        /// </summary>
        public string WrapperTool => "WrapperTool";
    }
}
