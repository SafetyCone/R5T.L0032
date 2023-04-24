using System;

using R5T.T0131;

using R5T.L0030.T000;
using R5T.L0030.T000.Extensions;


namespace R5T.L0032.Z000
{
    /// <summary>
    /// Element names used in Visual Studio project XML files.
    /// </summary>
    /// <remarks>
    /// Prior work: R5T.F0020.
    /// </remarks>
    [ValuesMarker]
    public partial interface IProjectElementNames : IValuesMarker
    {
        public IElementName Authors => "Authors".ToElementName();
        public IElementName CheckEolTargetFramework => "CheckEolTargetFramework".ToElementName();
        public IElementName Company => "Company".ToElementName();
        public IElementName COMReference => "COMReference".ToElementName();
        public IElementName Copyright => "Copyright".ToElementName();
        public IElementName CopyToOutputDirectory => "CopyToOutputDirectory".ToElementName();
        public IElementName Description => "Description".ToElementName();
        public IElementName EmbedInteropTypes => "EmbedInteropTypes".ToElementName();
        public IElementName FrameworkReference => "FrameworkReference".ToElementName();
        public IElementName GenerateDocumentationFile => "GenerateDocumentationFile".ToElementName();
        public IElementName Guid => "Guid".ToElementName();
        public IAttributeName Include => "Include".ToAttributeName();
        public IElementName ItemGroup => "ItemGroup".ToElementName();
        public IElementName Isolated => "Isolated".ToElementName();
        public IAttributeName Label => "Label".ToAttributeName();
        public IElementName Lcid => "Lcid".ToElementName();
        public IElementName None => "None".ToElementName();
        public IElementName NoWarn => "NoWarn".ToElementName();
        public IElementName OutputType => "OutputType".ToElementName();
        public IElementName PackageLicenseExpression => "PackageLicenseExpression".ToElementName();
        public IElementName PackageReadmeFile => "PackageReadmeFile".ToElementName();
        public IElementName PackageReference => "PackageReference".ToElementName();
        public IElementName PackageRequireLicenseAcceptance => "PackageRequireLicenseAcceptance".ToElementName();
        public IElementName PackageTags => "PackageTags".ToElementName();
        public IElementName Project => "Project".ToElementName();
        public IElementName ProjectReference => "ProjectReference".ToElementName();
        public IElementName PropertyGroup => "PropertyGroup".ToElementName();
        public IElementName RepositoryUrl => "RepositoryUrl".ToElementName();
        public IElementName RootNamespace => "RootNamespace".ToElementName();
        public IAttributeName Sdk => "Sdk".ToAttributeName();
        public IElementName SupportedPlatform => "SupportedPlatform".ToElementName();
        public IElementName TargetFramework => "TargetFramework".ToElementName();
        public IElementName TargetFrameworkVersion => "TargetFrameworkVersion".ToElementName();
        public IAttributeName Update => "Update".ToAttributeName();
        public IElementName UseWindowsForms => "UseWindowsForms".ToElementName();
        public IElementName Version => "Version".ToElementName();
        public IElementName VersionMinor => "VersionMinor".ToElementName();
        public IElementName VersionMajor => "VersionMajor".ToElementName();
        public IElementName WrapperTool => "WrapperTool".ToElementName();
    }
}
