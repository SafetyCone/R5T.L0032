using System;
using System.Collections.Generic;
using System.Xml.Linq;

using R5T.L0030.Extensions;
using R5T.L0030.T000;
using R5T.L0089.T000;
using R5T.N0003;
using R5T.T0132;
using R5T.T0198;
using R5T.T0202;
using R5T.T0218.Extensions;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;

using ITargetFrameworkMoniker = R5T.T0218.ITargetFrameworkMoniker;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IProjectElementOperator : IFunctionalityMarker,
        F000.IProjectElementOperator
    {
        private static Internal.IProjectElementOperator Internal => L0032.Internal.ProjectElementOperator.Instance;


        public IPackagePropertyGroupElement Add_PackagePropertyGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return Internal.Acquire_PackagePropertyGroup(projectElement);
        }

        /// <summary>
        /// Chooses <see cref="Add_PackagePropertyGroup_Idempotent(IProjectElement)"/> as the default.
        /// </summary>
        public IPackagePropertyGroupElement Add_PackagePropertyGroup(IProjectElement projectElement)
        {
            return this.Add_PackagePropertyGroup_Idempotent(projectElement);
        }

        public void Ensure_HasPrivateGitHubRepositoryProperty(IProjectElement projectElement)
        {
            Instances.ProjectXmlOperator.In_CustomPropertyGroupElementContext(
                projectElement,
                Instances.CustomPropertyGroupElementOperator.Ensure_HasPrivateGitHubRepositoryProperty);
        }

        public IProjectElement New_ProjectElement()
        {
            var projectElement = Instances.ProjectXElementOperator.New_ProjectXElement()
                .ToProjectElement();

            return projectElement;
        }

        public void Order_MainPropertyGroupNodes(IProjectElement projectElement)
        {
            var mainPropertyGroupElement = Internal.Acquire_MainPropertyGroup(projectElement);

            mainPropertyGroupElement.Value.OrderChildren_ByNames(
                Instances.ProjectElementNameSets.MainPropertyGroupOrderedNames_Default);
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

        public void Ensure_Has_GenerateDocumentationFile(
            IProjectElement projectElement)
        {
            var hasGenerateDocumentationFileElement = this.Has_GenerateDocumentationFileElement(projectElement);
            if(!hasGenerateDocumentationFileElement)
            {
                this.Set_GenerateDocumentationFile(projectElement);
            }
        }

        public WasFound<XElement> Has_GenerateDocumentationFileElement(IProjectElement projectElement)
        {
            var output = Internal.Has_PropertyGroup_ChildElement(
                projectElement,
                Instances.ProjectElementNames.GenerateDocumentationFile.Value);

            return output;
        }

        public void Set_GenerateDocumentationFile(
            IProjectElement projectElement,
            bool value = true)
        {
            var valueString = Instances.BooleanOperator.To_String_ForProjectXml(value);

            Internal.Set_MainPropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.GenerateDocumentationFile,
                valueString);
        }

        public void Ensure_Has_NoWarn_ElseSetNoWarnValues(
            IProjectElement projectElement,
            IEnumerable<IWarning> warnings)
        {
            var hasNoWarnElement = this.Has_NoWarnElement(projectElement);
            if (!hasNoWarnElement)
            {
                this.Set_NoWarn(
                    projectElement,
                    warnings);
            }
        }

        public WasFound<XElement> Has_NoWarnElement(IProjectElement projectElement)
        {
            var output = Internal.Has_PropertyGroup_ChildElement(
                projectElement,
                Instances.ProjectElementNames.NoWarn.Value);

            return output;
        }

        public void Set_NoWarn(
            IProjectElement projectElement,
            IEnumerable<IWarning> warnings)
        {
            var valueString = Instances.ProjectOperator.Get_WarningsConcatenation(warnings);

            this.Set_NoWarn(
                projectElement,
                valueString);
        }

        public void Set_NoWarn(
            IProjectElement projectElement,
            string concatenatedWarnings)
        {
            Internal.Set_MainPropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.NoWarn,
                concatenatedWarnings);
        }

        public void Set_OutputType(
            IProjectElement projectElement,
            IOutputType outputType)
        {
            Internal.Set_MainPropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.OutputType,
                outputType.Value);
        }
        
        /// <summary>
        /// Allows setting the value of an element of the specified in any item group.
        /// </summary>
        public void Set_ItemGroupElementValue(
            IProjectElement projectElement,
            IElementName elementName,
            string value)
        {
            Internal.Set_ItemGroupElementValue(
                projectElement,
                elementName,
                value);
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

        public void Set_PackagePropertyGroupElementValue(
            IProjectElement projectElement,
            IElementName childPropertyElementName,
            string value)
        {
            var propertyGroup = Internal.Acquire_PackagePropertyGroup(projectElement);

            var propertyElement = propertyGroup.Value.Acquire_Child(childPropertyElementName);

            propertyElement.Value = value;
        }

        public void Set_PackageRequireLicenseAcceptance(
            IProjectElement projectElement,
            bool requireLicenseAcceptance)
        {
            var value = Instances.BooleanOperator.To_String_ForProjectXml(requireLicenseAcceptance);

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

        public void Set_SupportedPlatform(
            IProjectElement projectElement,
            ISupportedPlatform supportedPlatform)
        {
            var supportedPlatformElement = Instances.ProjectXmlOperator_Internal.Acquire_ItemGroupChild(
                projectElement,
                Instances.ProjectElementNames.SupportedPlatform);

            Instances.ProjectXmlOperator.Set_IncludeAttributeValue(
                supportedPlatformElement,
                supportedPlatform.Value);
        }

        public WasFound<ITargetFrameworkMoniker> Has_TargetFrameworkElement(IProjectElement projectElement)
        {
            var output = Internal.Has_PropertyGroup_ChildElementValue(
                projectElement,
                Instances.ProjectElementNames.TargetFramework.Value)
                .Convert(targetFramework => targetFramework.ToTargetFrameworkMoniker());

            return output;
        }

        public ITargetFrameworkMoniker Get_TargetFramework(IProjectElement projectElement)
        {
            var output = this.Has_TargetFrameworkElement(projectElement)
                .Get_Result_OrExceptionIfNotFound("No target framework element found.");

            return output;
        }

        public void Set_TargetFramework(
            IProjectElement projectElement,
            ITargetFrameworkMoniker targetFrameworkMoniker)
        {
            Internal.Set_MainPropertyGroupElementValue(
                projectElement,
                Instances.ProjectElementNames.TargetFramework,
                targetFrameworkMoniker.Value);
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
    }
}
