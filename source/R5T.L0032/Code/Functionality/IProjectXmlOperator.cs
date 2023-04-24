using System;
using System.Collections.Generic;
using System.Linq;

using R5T.F0120;
using R5T.L0030.Extensions;
using R5T.L0030.T000;
using R5T.T0132;
using R5T.T0172;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IProjectXmlOperator : IFunctionalityMarker
    {
        private static Internal.IProjectXmlOperator Internal => L0032.Internal.ProjectXmlOperator.Instance;


        public IMainPropertyGroupElement Acquire_MainPropertyGroup(IProjectElement projectElement)
        {
            var hasMainPropertyGroupElement = Internal.Has_MainPropertyGroup(projectElement);
            if (!hasMainPropertyGroupElement)
            {
                var output = Internal.Add_MainPropertyGroup(projectElement);
                return output;
            }

            return hasMainPropertyGroupElement.Result;
        }

        public IMainPropertyGroupElement Add_MainPropertyGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return this.Acquire_MainPropertyGroup(projectElement);
        }

        /// <summary>
        /// Chooses <see cref="Add_MainPropertyGroup_Idempotent(IProjectElement)"/> as the default.
        /// </summary>
        public IMainPropertyGroupElement Add_MainPropertyGroup(IProjectElement projectElement)
        {
            return this.Add_MainPropertyGroup_Idempotent(projectElement);
        }

        public IPackagePropertyGroupElement Acquire_PackagePropertyGroup(IProjectElement projectElement)
        {
            var hasPackageGroupElement = Internal.Has_PackagePropertyGroup(projectElement);
            if (!hasPackageGroupElement)
            {
                var output = Internal.Add_PackagePropertyGroup(projectElement);
                return output;
            }

            return hasPackageGroupElement.Result;
        }

        public IPackagePropertyGroupElement Add_PackagePropertyGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return this.Acquire_PackagePropertyGroup(projectElement);
        }

        /// <summary>
        /// Chooses <see cref="Add_MainPropertyGroup_Idempotent(IProjectElement)"/> as the default.
        /// </summary>
        public IPackagePropertyGroupElement Add_PackagePropertyGroup(IProjectElement projectElement)
        {
            return this.Add_PackagePropertyGroup_Idempotent(projectElement);
        }

        public void Set_Sdk(IProjectElement projectElement, IProjectSdkName projectSdkName)
        {
            var sdkAttribute = Internal.Acquire_SdkAttribute(projectElement);

            sdkAttribute.Value = projectSdkName.Value;
        }

        public ICOMReferenceItemGroupElement Acquire_COMReferencesItemGroup(IProjectElement projectElement)
        {
            return Internal.Acquire_COMReferencesItemGroup(projectElement);
        }

        public ICOMReferenceItemGroupElement Add_COMReferencesItemGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return this.Acquire_COMReferencesItemGroup(projectElement);
        }

        /// <summary>
        /// Chooses <see cref="Add_MainPropertyGroup_Idempotent(IProjectElement)"/> as the default.
        /// </summary>
        public ICOMReferenceItemGroupElement Add_COMReferencesItemGroup(IProjectElement projectElement)
        {
            return this.Add_COMReferencesItemGroup_Idempotent(projectElement);
        }

        public ICOMReferenceElement Add_COMReference(
            IProjectElement projectElement,
            COMReference comReference)
        {
            return Internal.Add_COMReference(projectElement, comReference);
        }

        public IPackageReferenceElement Add_PackageReference(
            IProjectElement projectElement,
            PackageReference packageReference)
        {
            return Internal.Add_PackageReference(
                projectElement,
                packageReference);
        }

        public Dictionary<PackageReference, IPackageReferenceElement> Add_PackageReferences(
            IProjectElement projectElement,
            IEnumerable<PackageReference> packageReferences)
        {
            return Internal.Add_PackageReferences(
                projectElement,
                packageReferences);
        }

        public Dictionary<PackageReference, IPackageReferenceElement> Add_PackageReferences(
            IProjectElement projectElement,
            params PackageReference[] packageReferences)
        {
            return this.Add_PackageReferences(
                projectElement,
                packageReferences.AsEnumerable());
        }

        public Dictionary<IProjectDirectoryRelativePath, IProjectReferenceElement> Add_ProjectReferences(
            IProjectElement projectElement,
            IEnumerable<IProjectDirectoryRelativePath> projectReferenceRelativePaths)
        {
            return Internal.Add_ProjectReferences(
                projectElement,
                projectReferenceRelativePaths);
        }

        public Dictionary<IProjectDirectoryRelativePath, IProjectReferenceElement> Add_ProjectReferences(
            IProjectElement projectElement,
            params IProjectDirectoryRelativePath[] projectReferenceRelativePaths)
        {
            return this.Add_ProjectReferences(
                projectElement,
                projectReferenceRelativePaths.AsEnumerable());
        }

        public IProjectReferenceElement Add_ProjectReference(
            IProjectElement projectElement,
            IProjectDirectoryRelativePath projectReferenceRelativePath)
        {
            return this.Add_ProjectReferences(
                projectElement,
                projectReferenceRelativePath)
                .First()
                .Value;
        }

        public (IProjectFilePath projectFilePath, IProjectReferenceElement projectReferenceElement)[] Add_ProjectReferences(
            IProjectElement projectElement,
            IProjectFilePath projectFilePath,
            IEnumerable<IProjectFilePath> projectReferenceFilePaths)
        {
            var tuples = Instances.ProjectPathsOperator.Get_ProjectDirectoryRelativePaths(
                projectFilePath,
                projectReferenceFilePaths)
                .Select(tuple =>
                {
                    var projectReferenceElement = this.Add_ProjectReference(projectElement, tuple.projectDirectoryRelativePath);

                    return (tuple.projectFilePath, projectReferenceElement);
                })
                .Now();

            return tuples;
        }

        public (IProjectFilePath projectFilePath, IProjectReferenceElement projectReferenceElement)[] Add_ProjectReferences(
            IProjectElement projectElement,
            IProjectFilePath projectFilePath,
            params IProjectFilePath[] projectReferenceFilePaths)
        {
            return this.Add_ProjectReferences(
                projectElement,
                projectFilePath,
                projectReferenceFilePaths.AsEnumerable());
        }

        public IProjectReferenceElement Add_ProjectReference(
            IProjectElement projectElement,
            IProjectFilePath projectFilePath,
            IProjectFilePath projectReferenceFilePath)
        {
            return this.Add_ProjectReferences(
                projectElement,
                projectFilePath,
                projectReferenceFilePath)
                .First()
                .projectReferenceElement;
        }

        public (IProjectDirectoryRelativePath projectDirectoryRelativePath, ICopyToOutputElement copyToOutputElement)[] Add_CopyToOutputs(
            IProjectElement projectElement,
            IEnumerable<IProjectDirectoryRelativePath> fileRelativePaths)
        {
            return Internal.Add_CopyToOutputs(
                projectElement,
                fileRelativePaths);
        }

        public (IProjectDirectoryRelativePath projectDirectoryRelativePath, ICopyToOutputElement copyToOutputElement)[] Add_CopyToOutputs(
            IProjectElement projectElement,
            params IProjectDirectoryRelativePath[] fileRelativePaths)
        {
            return this.Add_CopyToOutputs(
                projectElement,
                fileRelativePaths.AsEnumerable());
        }

        public ICopyToOutputElement Add_CopyToOutput(
            IProjectElement projectElement,
            IProjectDirectoryRelativePath fileRelativePath)
        {
            return this.Add_CopyToOutputs(
                projectElement,
                fileRelativePath)
                .First()
                .copyToOutputElement;
        }

        public IProjectReferenceItemGroupElement Acquire_ProjectReferencesItemGroup(IProjectElement projectElement)
        {
            return Internal.Acquire_ProjectReferencesItemGroup(projectElement);
        }

        public IProjectReferenceItemGroupElement Add_ProjectReferencesItemGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return this.Acquire_ProjectReferencesItemGroup(projectElement);
        }

        /// <summary>
        /// Chooses <see cref="Add_MainPropertyGroup_Idempotent(IProjectElement)"/> as the default.
        /// </summary>
        public IProjectReferenceItemGroupElement Add_ProjectReferencesItemGroup(IProjectElement projectElement)
        {
            return this.Add_ProjectReferencesItemGroup_Idempotent(projectElement);
        }

        public IPackageReferenceItemGroupElement Acquire_PackageReferencesItemGroup(IProjectElement projectElement)
        {
            return Internal.Acquire_PackageReferencesItemGroup(projectElement);
        }

        public IPackageReferenceItemGroupElement Add_PackageReferencesItemGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return this.Acquire_PackageReferencesItemGroup(projectElement);
        }

        /// <summary>
        /// Chooses <see cref="Add_MainPropertyGroup_Idempotent(IProjectElement)"/> as the default.
        /// </summary>
        public IPackageReferenceItemGroupElement Add_PackageReferencesItemGroup(IProjectElement projectElement)
        {
            return this.Add_PackageReferencesItemGroup_Idempotent(projectElement);
        }

        public ICopyToOutputItemGroupElement Acquire_CopyToOutputItemGroup(IProjectElement projectElement)
        {
            return Internal.Acquire_CopyToOutputItemGroup(projectElement);
        }

        public ICopyToOutputItemGroupElement Add_CopyToOutputItemGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return this.Acquire_CopyToOutputItemGroup(projectElement);
        }

        /// <summary>
        /// Chooses <see cref="Add_MainPropertyGroup_Idempotent(IProjectElement)"/> as the deSfault.
        /// </summary>
        public ICopyToOutputItemGroupElement Add_CopyToOutputItemGroup(IProjectElement projectElement)
        {
            return this.Add_CopyToOutputItemGroup_Idempotent(projectElement);
        }

        public void Set_MainPropertyGroupElementValue(
            IProjectElement projectElement,
            IElementName childPropertyElementName,
            string value)
        {
            var mainPropertyGroup = this.Acquire_MainPropertyGroup(projectElement);

            var targetFrameworkElement = mainPropertyGroup.Value.Acquire_Child(childPropertyElementName);

            targetFrameworkElement.Value = value;
        }

        public void Set_TargetFramework(
            IProjectElement projectElement,
            ITargetFrameworkMoniker targetFrameworkMoniker)
        {
            this.Set_MainPropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.TargetFramework,
                targetFrameworkMoniker.Value);
        }

        public void Set_PackagePropertyGroupElementValue(
            IProjectElement projectElement,
            IElementName childPropertyElementName,
            string value)
        {
            var propertyGroup = this.Acquire_PackagePropertyGroup(projectElement);

            var propertyElement = propertyGroup.Value.Acquire_Child(childPropertyElementName);

            propertyElement.Value = value;
        }

        public void Set_Version(
            IProjectElement projectElement,
            IVersionString versionString)
        {
            this.Set_PackagePropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.Version,
                versionString.Value);
        }

        public void Set_Version(
            IProjectElement projectElement,
            Version version)
        {
            var versionString = Instances.VersionOperator.ToVersionString_ForProjectXml(version);

            this.Set_Version(
                projectElement,
                versionString);
        }

        public IProjectElement New_ProjectElement()
        {
            var projectElement = Instances.XmlOperator.New_Element(
                Instances.ProjectElementNames.Project)
                .ToProjectElement();

            return projectElement;
        }

        /// <summary>
        /// When you use a Nuget user name as the author for your package, users on Nuget.org can click the author to see all packages by the author.
        /// </summary>
        public void Set_Author(
            IProjectElement projectElement,
            INugetUserName nugetUserName)
        {
            this.Set_PackagePropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.Authors,
                nugetUserName.Value);
        }

        public void Set_Company(
            IProjectElement projectElement,
            ICompanyName companyName)
        {
            this.Set_PackagePropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.Company,
                companyName.Value);
        }

        public void Set_Copyright(
            IProjectElement projectElement,
            string copyrightText)
        {
            this.Set_PackagePropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.Copyright,
                copyrightText);
        }

        public void Set_Copyright_FromCopyrightHolder(
            IProjectElement projectElement,
            string copyrightHolder)
        {
            var copyrightText = Instances.CopyrightOperator.Get_CopyrightText(copyrightHolder);

            this.Set_Copyright(
                projectElement,
                copyrightText);
        }

        public void Set_Description(
            IProjectElement projectElement,
            IDescription description)
        {
            this.Set_Description(
                projectElement,
                description.Value);
        }

        public void Set_Description(
            IProjectElement projectElement,
            string description)
        {
            this.Set_PackagePropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.Description,
                description);
        }

        public void Set_PackageLicenseExpression(
            IProjectElement projectElement,
            IPackageLicenseExpression packageLicenseExpression)
        {
            this.Set_PackagePropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.PackageLicenseExpression,
                packageLicenseExpression.Value);
        }

        public void Set_PackageRequireLicenseAcceptance(
            IProjectElement projectElement,
            bool requireLicenseAcceptance)
        {
            var value = Instances.BooleanOperator.ToString_ForProjectXml(requireLicenseAcceptance);

            this.Set_PackagePropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.PackageRequireLicenseAcceptance,
                value);
        }

        public void Set_RepositoryUrl(
            IProjectElement projectElement,
            IRepositoryUrl repositoryUrl)
        {
            this.Set_PackagePropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.RepositoryUrl,
                repositoryUrl.Value);
        }
    }
}
