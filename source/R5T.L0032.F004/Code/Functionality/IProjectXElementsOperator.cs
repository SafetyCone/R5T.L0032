using System;
using System.Xml.Linq;

using R5T.T0132;
using R5T.T0206;

using R5T.L0032.F003.Extensions;
using System.Collections.Generic;
using System.Linq;
using R5T.L0032.Z001;


namespace R5T.L0032.F004
{
    /// <summary>
    /// Contains XElement-level operations on all of a project XElement's XElements (not just the project XElement itself).
    /// For operations only on the project XElement, see (the closely named) <see cref="IProjectXElementOperator"/>.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    [FunctionalityMarker]
    public partial interface IProjectXElementsOperator : IFunctionalityMarker
    {
        public XAttribute Acquire_IncludeAttribute(XElement includeAttributedElement)
        {
            var includeAttribute = Instances.XElementOperator.Acquire_Attribute(
                includeAttributedElement,
                Instances.ProjectNodeNames.Include);

            return includeAttribute;
        }

        public XAttribute Acquire_LabelAttribute(XElement labelAttributedElement)
        {
            var labelAttribute = Instances.XElementOperator.Acquire_Attribute(
                labelAttributedElement,
                Instances.ProjectNodeNames.Label);

            return labelAttribute;
        }

        /// <summary>
        /// <inheritdoc cref="L0066.IXElementOperator.Acquire_Attribute(XElement, string)" path="/summary"/>
        /// <inheritdoc cref="Z001.IProjectNodeNames.Sdk" path="/summary"/>
        /// </summary>
        public XAttribute Acquire_SdkAttribute(XElement projectElement)
        {
            var sdkAttribute = Instances.XElementOperator.Acquire_Attribute(
                projectElement,
                Instances.ProjectNodeNames.Sdk);

            return sdkAttribute;
        }

        public XAttribute Acquire_VersionAttribute(XElement versionAttributedElement)
        {
            var includeAttribute = Instances.XElementOperator.Acquire_Attribute(
                versionAttributedElement,
                Instances.ProjectNodeNames.Version);

            return includeAttribute;
        }

        public XElement Add_COMReference(
            XElement itemGroupElement,
            COMReference comReference)
        {
            var comReferenceElement = this.Get_COMReferenceElement(comReference);

            Instances.XElementOperator.Add_Child(
                itemGroupElement,
                comReferenceElement);

            return comReferenceElement;
        }

        public XAttribute Add_LabelAttribute(XElement labelAttributedElement)
        {
            var output = Instances.XElementOperator.Add_Attribute(
                labelAttributedElement,
                Instances.ProjectNodeNames.Label);

            return output;
        }

        public XAttribute Add_LabelAttribute(
            XElement labelAttributedElement,
            string value)
        {
            var output = this.Add_LabelAttribute(labelAttributedElement);

            Instances.XAttributeOperator.Set_Value(
                output,
                value);

            return output;
        }

        public XElement Add_SupportedPlatform(
            XElement itemGroupElement,
            string includeValue)
        {
            var packageReferenceElement = this.Get_SupportedPlatform(includeValue);

            Instances.XElementOperator.Add_Child(
                itemGroupElement,
                packageReferenceElement);

            return packageReferenceElement;
        }

        public XElement Add_Folder(
            XElement itemGroupElement,
            string relativePath)
        {
            var packageReferenceElement = this.Get_FolderElement(relativePath);

            Instances.XElementOperator.Add_Child(
                itemGroupElement,
                packageReferenceElement);

            return packageReferenceElement;
        }

        /// <summary>
        /// Adds a package reference, returning the package reference element.
        /// </summary>
        public XElement Add_PackageReference(
            XElement itemGroupElement,
            PackageReference packageReference)
        {
            var packageReferenceElement = this.Get_PackageReferenceElement(packageReference);

            Instances.XElementOperator.Add_Child(
                itemGroupElement,
                packageReferenceElement);

            return packageReferenceElement;
        }

        public XElement Add_ProjectReference(
            XElement itemGroupElement,
            string projectFilePath,
            string referenceProjectFilePath)
        {
            var relativeReferenceProjectFilePath = Instances.ProjectPathsOperator.Get_RelativeReferenceProjectFilePath(
                projectFilePath,
                referenceProjectFilePath);

            var output = this.Add_ProjectReference(
                itemGroupElement,
                relativeReferenceProjectFilePath);

            return output;
        }

        public XElement Add_ProjectReference(
            XElement itemGroupElement,
            string relativeReferenceProjectFilePath)
        {
            var projectReferenceElement = Instances.ProjectXElementsOperator.New_ProjectReferenceXElement(relativeReferenceProjectFilePath);

            Instances.XElementOperator.Add(
                itemGroupElement,
                projectReferenceElement);

            return projectReferenceElement;
        }

        public Dictionary<string, XElement> Add_ProjectReferences(
            XElement itemGroupElement,
            string projectFilePath,
            IEnumerable<string> referenceProjectFilePaths)
        {
            var relativeReferenceProjectFilePaths = Instances.ProjectPathsOperator.Get_RelativeReferenceProjectFilePaths(
                projectFilePath,
                referenceProjectFilePaths);

            var output = relativeReferenceProjectFilePaths
                .Select(relativeReferenceProjectFilePath =>
                {
                    var projectReferenceXElement = this.Add_ProjectReference(
                        itemGroupElement,
                        relativeReferenceProjectFilePath);

                    return (relativeReferenceProjectFilePath, projectReferenceXElement);
                })
                .ToDictionary(
                    x => x.relativeReferenceProjectFilePath,
                    x => x.projectReferenceXElement);

            return output;
        }

        public Dictionary<string, XElement> Add_ProjectReferences(
            XElement itemGroupElement,
            string projectFilePath,
            params string[] referenceProjectFilePaths)
        {
            return this.Add_ProjectReferences(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths.AsEnumerable());
        }

        public XElement[] Add_ProjectReferences_ReturnArray(
            XElement itemGroupElement,
            string projectFilePath,
            IEnumerable<string> referenceProjectFilePaths)
        {
            var output = this.Add_ProjectReferences(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths)
                .Values
                .ToArray();

            return output;
        }

        public XElement[] Add_ProjectReferences_ReturnArray(
            XElement itemGroupElement,
            string projectFilePath,
            params string[] referenceProjectFilePaths)
        {
            var output = this.Add_ProjectReferences_ReturnArray(
                itemGroupElement,
                projectFilePath,
                referenceProjectFilePaths.AsEnumerable());

            return output;
        }

        public XElement Append_NewPropertyGroupXElement(XElement projectElement)
        {
            var propertyGroupXElement = Instances.XElementOperator.Append_Child(
                projectElement,
                this.New_PropertyGroupXElement);

            return propertyGroupXElement;
        }

        public void Append_ItemGroupXElement(
            XElement projectElement,
            XElement itemGroupElement)
        {
            Instances.XElementOperator.Append_Child(
                projectElement,
                itemGroupElement);
        }

        public void Append_PropertyGroupXElement(
            XElement projectElement,
            XElement propertyGroupElement)
        {
            Instances.XElementOperator.Append_Child(
                projectElement,
                propertyGroupElement);
        }

        public XElement Append_NewItemGroupXElement(XElement projectElement)
        {
            var propertyGroupXElement = Instances.XElementOperator.Append_Child(
                projectElement,
                this.New_ItemGroupXElement);

            return propertyGroupXElement;
        }

        public XElement Get_COMReferenceElement(COMReference comReference)
        {
            var comReferenceElement = this.New_COMReferenceXElement();

            this.Set_Include(
                comReferenceElement,
                comReference.Name);

            var comReferenceProperties = new[]
            {
                Instances.XElementOperator.New(
                    Instances.ProjectNodeNames.WrapperTool,
                    comReference.WrapperTool),
                Instances.XElementOperator.New(
                    Instances.ProjectNodeNames.VersionMinor,
                    comReference.Version_Minor.To_String_ForProjectXml()),
                Instances.XElementOperator.New(
                    Instances.ProjectNodeNames.VersionMajor,
                    comReference.Version_Major.To_String_ForProjectXml()),
                Instances.XElementOperator.New(
                    Instances.ProjectNodeNames.Guid,
                    comReference.Guid.To_String_ForCOMReference()),
                Instances.XElementOperator.New(
                    Instances.ProjectNodeNames.Lcid,
                    comReference.Lcid.To_String_ForProjectXml()),
                Instances.XElementOperator.New(
                    Instances.ProjectNodeNames.Isolated,
                    comReference.Isolated.To_String_ForProjectXml()),
                Instances.XElementOperator.New(
                    Instances.ProjectNodeNames.EmbedInteropTypes,
                    comReference.EmbedInteropTypes.To_String_ForProjectXml())
            };

            Instances.XElementOperator.Add_Children(
                comReferenceElement,
                comReferenceProperties);

            return comReferenceElement;
        }

        public XElement Get_SupportedPlatform(string includeValue)
        {
            var packageReferenceElement = this.New_SupportedPlatform();

            this.Set_Include(
                packageReferenceElement,
                includeValue);

            return packageReferenceElement;
        }

        public XElement Get_FolderElement(string relativePath)
        {
            var packageReferenceElement = this.New_FolderElement();

            this.Set_Include(
                packageReferenceElement,
                relativePath);

            return packageReferenceElement;
        }

        public XElement Get_PackageReferenceElement(PackageReference packageReference)
        {
            var packageReferenceElement = this.New_PackageReferenceElement();

            this.Set_Include(
                packageReferenceElement,
                packageReference.Name);

            this.Set_VersionAttribute(
                packageReferenceElement,
                packageReference.Version);

            return packageReferenceElement;
        }

        public bool Has_LabelAttribute(
            XElement element,
            out XAttribute labelAttributeOrDefault)
        {
            var output = Instances.XElementOperator.Has_Attribute(
                element,
                Instances.ProjectNodeNames.Label,
                out labelAttributeOrDefault);

            return output;
        }

        public XElement In_NewPropertyGroupXElementContext(
            XElement projectElement,
            IEnumerable<Action<XElement>> propertyGroupActions)
        {
            var propertyGroupXElement = this.Append_NewPropertyGroupXElement(projectElement);

            Instances.ContextOperator.In_Context(
                propertyGroupXElement,
                propertyGroupActions);

            return propertyGroupXElement;
        }

        public XElement In_NewItemGroupXElementContext(
            XElement projectElement,
            IEnumerable<Action<XElement>> itemGroupActions)
        {
            var propertyGroupXElement = this.Append_NewItemGroupXElement(projectElement);

            Instances.ContextOperator.In_Context(
                propertyGroupXElement,
                itemGroupActions);

            return propertyGroupXElement;
        }

        public XElement New_COMReferenceXElement()
        {
            var comReferenceElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.COMReference);

            return comReferenceElement;
        }

        public XElement New_FolderElement()
        {
            var comReferenceElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.Folder);

            return comReferenceElement;
        }

        public XElement New_SupportedPlatform()
        {
            var comReferenceElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.SupportedPlatform);

            return comReferenceElement;
        }

        public XElement New_ItemGroupXElement()
        {
            var propertyGroupElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.ItemGroup);

            return propertyGroupElement;
        }

        public XElement New_PackageReferenceElement()
        {
            var comReferenceElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.PackageReference);

            return comReferenceElement;
        }

        public XElement New_ProjectXElement()
        {
            var projectElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.Project);

            return projectElement;
        }

        public XElement New_ProjectReferenceXElement()
        {
            var output = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.ProjectReference);

            return output;
        }

        public XElement New_ProjectReferenceXElement(
            string projectFilePath,
            string referenceProjectFilePath)
        {
            var relativeReferenceProjectFilePath = Instances.ProjectPathsOperator.Get_RelativeReferenceProjectFilePath(
                projectFilePath,
                referenceProjectFilePath);

            var projectReferenceElement = this.New_ProjectReferenceXElement(relativeReferenceProjectFilePath);
            return projectReferenceElement;
        }

        public XElement New_ProjectReferenceXElement(
            string relativeReferenceProjectFilePath)
        {
            var projectReferenceElement = this.New_ProjectReferenceXElement();

            // Ignore returned attribute.
            this.Set_Include(
                projectReferenceElement,
                relativeReferenceProjectFilePath);

            return projectReferenceElement;
        }

        public XElement New_PropertyGroupXElement()
        {
            var propertyGroupElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames.PropertyGroup);

            return propertyGroupElement;
        }

        /// <summary>
        /// <inheritdoc cref="Y000.Documentation.ForAuthorsElement" path="/summary"/>
        /// </summary>
        public XElement Set_Authors(
            XElement propertyGroupElement,
            string authorsValue)
        {
            var outputTypeElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.Authors,
                authorsValue);

            return outputTypeElement;
        }

        /// <inheritdoc cref="Set_Authors(XElement, string)"/>
        public XElement Set_Authors(
            XElement propertyGroupElement,
            IEnumerable<string> authors)
        {
            var authorsValue = Instances.AuthorsOperator.Combine(authors);

            return this.Set_Authors(
                propertyGroupElement,
                authorsValue);
        }

        /// <inheritdoc cref="Set_Authors(XElement, string)"/>
        public XElement Set_Authors(
            XElement propertyGroupElement,
            params string[] authors)
        {
            var authorsValue = Instances.AuthorsOperator.Combine(authors);

            return this.Set_Authors(
                propertyGroupElement,
                authorsValue);
        }

        public XElement Set_Company(
            XElement propertyGroupElement,
            string company)
        {
            var companyElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.Company,
                company);

            return companyElement;
        }

        public XElement Set_Copyright(
            XElement propertyGroupElement,
            string copyright)
        {
            var copyrightElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.Copyright,
                copyright);

            return copyrightElement;
        }

        public XElement Set_Description(
            XElement propertyGroupElement,
            string description)
        {
            var descriptionElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.Description,
                description);

            return descriptionElement;
        }

        public XElement Set_ImplicitUsings(
            XElement propertyGroupElement,
            string implicitUsingsValue)
        {
            var implicitUsingsElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.ImplicitUsings,
                implicitUsingsValue);

            return implicitUsingsElement;
        }

        public XAttribute Set_Include(
            XElement groupElement,
            string value)
        {
            var includeAttribute = this.Acquire_IncludeAttribute(groupElement);

            Instances.XAttributeOperator.Set_Value(
                includeAttribute,
                value);

            return includeAttribute;
        }

        public XAttribute Set_Label(
            XElement labelAttributedElement,
            string label)
        {
            var labelAttribute = this.Acquire_LabelAttribute(labelAttributedElement);

            Instances.XAttributeOperator.Set_Value(
                labelAttribute,
                label);

            return labelAttribute;
        }

        public XElement Set_NoDefaultLaunchSettingsFile(
            XElement propertyGroupElement,
            // Setting this at all means you probably want it to be true.
            bool value = true)
        {
            var valueString = Instances.BooleanOperator.To_String_ForProjectXml(value);

            var noDefaultLaunchSettingsFileElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.NoDefaultLaunchSettingsFile,
                valueString);

            return noDefaultLaunchSettingsFileElement;
        }

        public XElement Set_StaticWebAssetProjectMode(
            XElement propertyGroupElement,
            // Only the "Default" value is supported for Blazor WebAssembly projects (which are the main consumer of this setting).
            string valueString = IValues.Default_Constant)
        {
            var noWarnElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.StaticWebAssetProjectMode,
                valueString);

            return noWarnElement;
        }

        public XElement Set_NoWarn(
            XElement propertyGroupElement,
            string warningNumbersList)
        {
            var noWarnElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.NoWarn,
                warningNumbersList);

            return noWarnElement;
        }

        public XElement Set_Nullable(
            XElement propertyGroupElement,
            string nullableValue)
        {
            var nullableElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.Nullable,
                nullableValue);

            return nullableElement;
        }

        public XElement Set_OutputType(
            XElement propertyGroupElement,
            string outputTypeValue)
        {
            var outputTypeElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.OutputType,
                outputTypeValue);

            return outputTypeElement;
        }

        public XElement Set_PackageLicenseExpression(
            XElement propertyGroupElement,
            string packageLicenseExpression)
        {
            var packageLicenseExpressionElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.PackageLicenseExpression,
                packageLicenseExpression);

            return packageLicenseExpressionElement;
        }

        public XElement Set_PackageRequireLicenseAcceptance(
            XElement propertyGroupElement,
            bool value)
        {
            var valueString = Instances.BooleanOperator.To_String_ForProjectXml(value);

            var packageRequireLicenseAcceptanceElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.PackageRequireLicenseAcceptance,
                valueString);

            return packageRequireLicenseAcceptanceElement;
        }

        public XElement Set_RepositoryUrl(
            XElement propertyGroupElement,
            string repositoryUrl)
        {
            var repositoryUrlElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.RepositoryUrl,
                repositoryUrl);

            return repositoryUrlElement;
        }

        /// <summary>
        /// Sets the project element's SDK value.
        /// </summary>
        /// <remarks>
        /// For values of interest, see R5T.L0032.Z001.
        /// </remarks>
        public XAttribute Set_Sdk(
            XElement projectElement,
            string projectSdkName)
        {
            var sdkAttribute = this.Acquire_SdkAttribute(projectElement);

            sdkAttribute.Value = projectSdkName;

            return sdkAttribute;
        }

        public XElement Set_TargetFramework(
            XElement propertyGroupElement,
            string targetFrameworkValue)
        {
            var targetFrameworkElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.TargetFramework,
                targetFrameworkValue);

            return targetFrameworkElement;
        }

        public XElement Set_UseWindowsForms(
            XElement propertyGroupElement,
            string valueString)
        {
            var useWindowsFormsElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.UseWindowsForms,
                valueString);

            return useWindowsFormsElement;
        }

        public XElement Set_UseWindowsForms(
            XElement propertyGroupElement,
            bool value = true)
        {
            var valueString = Instances.BooleanOperator.To_String_ForProjectXml(value);

            return this.Set_UseWindowsForms(
                propertyGroupElement,
                valueString);
        }

        public void Set_Version(
            XElement versionElement,
            string versionString)
        {
            versionElement.Value = versionString;
        }

        public void Set_Version(
            XElement versionElement,
            Version version)
        {
            var versionString = version.To_String_ForProjectXml();

            this.Set_Version(
                versionElement,
                versionString);
        }

        public XAttribute Set_VersionAttribute(
            XElement versionAttributedElement,
            string versionString)
        {
            var versionAttribute = this.Acquire_VersionAttribute(versionAttributedElement);

            Instances.XAttributeOperator.Set_Value(
                versionAttribute,
                versionString);

            return versionAttribute;
        }

        public XAttribute Set_VersionAttribute(
            XElement versionAttributedElement,
            Version version)
        {
            var versionString = Instances.VersionOperator.ToString_ForProjectXml(version);

            var output = this.Set_VersionAttribute(
                versionAttributedElement,
                versionString);

            return output;
        }

        public XElement Set_Version_ForPropertyGroup(
            XElement propertyGroupElement,
            string versionString)
        {
            var versionElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames.Version,
                versionString);

            return versionElement;
        }

        public XElement Set_Version_ForPropertyGroup(
            XElement propertyGroupElement,
            Version version)
        {
            var versionString = Instances.VersionOperator.ToString_ForProjectXml(version);

            return this.Set_Version_ForPropertyGroup(
                propertyGroupElement,
                versionString);
        }
    }
}
