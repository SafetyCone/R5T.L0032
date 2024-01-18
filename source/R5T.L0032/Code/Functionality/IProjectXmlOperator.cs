using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

using R5T.L0030.Extensions;
using R5T.T0132;
using R5T.T0172;
using R5T.T0205;
using R5T.T0206;
using R5T.T0221;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;

using PackageReference = R5T.T0205.PackageReference;
using SimplePackageReference = R5T.T0208.PackageReference;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IProjectXmlOperator : IFunctionalityMarker
    {
        private static Internal.IProjectXmlOperator Internal => L0032.Internal.ProjectXmlOperator.Instance;


        public IMainPropertyGroupElement Add_MainPropertyGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return Instances.ProjectElementOperator_Internal.Acquire_MainPropertyGroup(projectElement);
        }

        /// <summary>
        /// Chooses <see cref="Add_MainPropertyGroup_Idempotent(IProjectElement)"/> as the default.
        /// </summary>
        public IMainPropertyGroupElement Add_MainPropertyGroup(IProjectElement projectElement)
        {
            return this.Add_MainPropertyGroup_Idempotent(projectElement);
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
            IEnumerable<IProjectDirectoryRelativePath> fileRelativepaths)
        {
            var projectReferenceElementsByRelativePath = fileRelativepaths
                .ToDictionary(
                    projectReferenceRelativePath => projectReferenceRelativePath,
                    projectReferenceRelativePath => Internal.Get_ProjectReferenceElement(projectReferenceRelativePath));

            var itemGroup = this.Acquire_ProjectReferencesItemGroup(projectElement);

            foreach (var packageReference in projectReferenceElementsByRelativePath.Values)
            {
                itemGroup.Value.Add_Child(packageReference.Value);
            }

            return projectReferenceElementsByRelativePath;
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

        public void Add_ProjectReferenceElement(
            IProjectElement projectElement,
            IProjectReferenceElement projectReferenceElement)
        {
            var itemGroup = this.Acquire_ProjectReferencesItemGroup(projectElement);

            itemGroup.Value.Add_Child(projectReferenceElement.Value);
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
            var hasGroupElement = this.Has_ProjectReferenceItemGroup(projectElement);
            if (!hasGroupElement)
            {
                var output = this.Add_ProjectReferencesItemGroup_NonIdempotent(projectElement);
                return output;
            }

            return hasGroupElement.Result;
        }

        /// <summary>
        /// Creates a new project references item group element, adds it to the project element, then returns the newly created and added item group element.
        /// </summary>
        /// <returns>The newly created and added item group element.</returns>
        public IProjectReferenceItemGroupElement Add_ProjectReferencesItemGroup_NonIdempotent(IProjectElement projectElement)
        {
            var groupElement = Internal.New_ProjectReferencesItemGroup();

            projectElement.Value.Add_Child(groupElement);

            return groupElement.ToProjectReferenceItemGroupElement();
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

        public IProjectReferenceItemGroupElement Add_ProjectReferencesItemGroup_Idempotent(IProjectElement projectElement)
        {
            // Acquire will add the property group if it does not exist.
            return this.Acquire_ProjectReferencesItemGroup(projectElement);
        }

        public SimplePackageReference[] Get_PackageReferences(IProjectElement projectElement)
        {
            var hasPackageReferenceItemGroup = Internal.Has_PackageReferenceItemGroup(projectElement);
            if(!hasPackageReferenceItemGroup)
            {
                return Instances.ArrayOperator.Empty<SimplePackageReference>();
            }

            var packageReferenceItemGroup = hasPackageReferenceItemGroup.Result;

            var packageReferenceElements = Internal.Get_PackageReferenceElements(packageReferenceItemGroup);

            var output = packageReferenceElements
                .Select(packageReferenceElement =>
                {
                    var packageName = this.Get_IncludeAttributeValue(packageReferenceElement.Value);
                    var version = Instances.XmlOperator.Get_AttributeValue(
                        packageReferenceElement.Value,
                        Instances.ProjectElementNames.Version);

                    var output = new SimplePackageReference
                    {
                        Identity = packageName,
                        Version = version,
                    };
                    return output;
                })
                .Now();

            return output;
        }

        public string Get_IncludeAttributeValue(XElement element)
        {
            var hasIncludeAttributeValue = this.Has_IncludeAttributeValue(element);

            var output = Instances.WasFoundOperator.ResultOrExceptionIfNotFound(hasIncludeAttributeValue);
            return output;
        }

        public void Set_IncludeAttributeValue(XElement element, string value)
        {
            var hasIncludeAttribute = Internal.Acquire_IncludeAttribute(element);

            Instances.XmlOperator.Set_Value(hasIncludeAttribute, value);
        }

        public WasFound<XElement> Has_PrivateGitHubRepositoryProperty(IProjectElement projectElement)
        {
            var hasCustomPropertyGroup = Instances.ProjectElementOperator_Internal.Has_CustomPropertyGroup(projectElement);

            var output = hasCustomPropertyGroup.Convert(
                Instances.CustomPropertyGroupElementOperator.Has_PrivateGitHubRepositoryProperty);

            return output;
        }
        
        public WasFound<XAttribute> Has_IncludeAttribute(XElement element)
        {
            var includeAttributeOrDefault = element.Get_Attributes()
                .Where_NameIs(Instances.ProjectElementNames.Include)
                // Use strict single instead of robust first since there should only be a single include attribute.
                .SingleOrDefault();

            var output = WasFound.From(includeAttributeOrDefault);
            return output;
        }
        
        public WasFound<string> Has_IncludeAttributeValue(XElement element)
        {
            var includeAttributeWasFound = this.Has_IncludeAttribute(element);
            if(!includeAttributeWasFound)
            {
                return WasFound.NotFound<string>();
            }

            var output = WasFound.Found(includeAttributeWasFound.Result.Value);
            return output;
        }

        public WasFound<XElement> Has_NoWarnElement(IProjectElement projectElement)
        {
            var output = Internal.Has_MainPropertyGroupChild(
                projectElement,
                Instances.ProjectElementNames.NoWarn);

            return output;
        }

        public WasFound<IProjectReferenceItemGroupElement> Has_ProjectReferenceItemGroup(IProjectElement projectElement)
        {
            // A project element might have multiple item group elements.
            // So what is the "Project References" item group element anyway?
            // Here the project references item group is defined via two methods:
            //  1. Is there an item group with a ProjectReference element?
            //  2. Is there an item group with a label attribute, with the project references value?
            // Otherwise, there is no project references item group element.
            // We don't take care if there is at least one item group. We want a project references item group.


            // Is there an item group with a COM references element?
            var hasItemGroup = Internal.Has_ItemGroup_WithChild(
                projectElement,
                Instances.ProjectElementNames.ProjectReference);

            if (hasItemGroup)
            {
                return hasItemGroup
                    .Convert(propertyGroupElement => propertyGroupElement.ToProjectReferenceItemGroupElement());
            }

            // Is there an item group with a label attribute, with the COM references value?
            var hasLabeledItemGroup = Internal.Has_LabeledItemGroup(
                projectElement,
                Instances.GroupLabels.ProjectReferences);

            if (hasLabeledItemGroup != default)
            {
                return WasFound.Found(hasLabeledItemGroup.Result.ToProjectReferenceItemGroupElement());
            }

            // There is no item group, so return not found.
            var notFound = WasFound.NotFound<IProjectReferenceItemGroupElement>();
            return notFound;
        }

        public void In_CustomPropertyGroupElementContext(
            IProjectElement projectElement,
            Action<ICustomPropertyGroupElement> customPropertyGroupElementAction = default)
        {
            var customPropertyGroupElement = Instances.ProjectElementOperator_Internal.Acquire_CustomPropertyGroup(projectElement);

            Instances.ActionOperator.Run(
                customPropertyGroupElement,
                customPropertyGroupElementAction);
        }

        public Task In_CustomPropertyGroupElementContext(
            IProjectElement projectElement,
            Func<ICustomPropertyGroupElement, Task> customPropertyGroupElementAction = default)
        {
            var customPropertyGroupElement = Instances.ProjectElementOperator_Internal.Acquire_CustomPropertyGroup(projectElement);

            return Instances.ActionOperator.Run(
                customPropertyGroupElementAction,
                customPropertyGroupElement);
        }

        /// <summary>
        /// Remote the output type element.
        /// Useful for web projects.
        /// </summary>
        public void Remove_OutputType(IProjectElement projectElement)
        {

        }
    }
}
