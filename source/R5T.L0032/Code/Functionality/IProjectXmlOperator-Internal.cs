using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using R5T.L0030.Extensions;
using R5T.L0030.T000;
using R5T.T0132;
using R5T.T0172;
using R5T.T0205;
using R5T.T0206;
using R5T.T0221;

using R5T.L0032.F003.Extensions;
using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;

using PackageReference = R5T.T0205.PackageReference;


namespace R5T.L0032.Internal
{
    [FunctionalityMarker]
    public partial interface IProjectXmlOperator : IFunctionalityMarker
    {
        public ICOMReferenceItemGroupElement Acquire_COMReferencesItemGroup(IProjectElement projectElement)
        {
            var hasGroupElement = this.Has_ComReferenceItemGroup(projectElement);
            if (!hasGroupElement)
            {
                var output = this.Add_COMReferenceItemGroup(projectElement);
                return output;
            }

            return hasGroupElement.Result;
        }

        public ICopyToOutputItemGroupElement Acquire_CopyToOutputItemGroup(IProjectElement projectElement)
        {
            var hasGroupElement = this.Has_CopyToOutputItemGroup(projectElement);
            if (!hasGroupElement)
            {
                var output = this.Add_CopyToOutputItemGroup(projectElement);
                return output;
            }

            return hasGroupElement.Result;
        }

        public XElement Acquire_ItemGroupChild(
            IProjectElement projectElement,
            IElementName elementName)
        {
            var hasItemGroup = this.Has_ItemGroup_WithChild(
                projectElement,
                elementName);

            var itemGroup = hasItemGroup
                ? hasItemGroup.Result
                : this.Add_ItemGroup(projectElement)
                ;

            var itemGroupChild = itemGroup.Acquire_Child(
                elementName);

            return itemGroupChild;
        }

        public IPackageReferenceItemGroupElement Acquire_PackageReferencesItemGroup(IProjectElement projectElement)
        {
            var hasGroupElement = this.Has_PackageReferenceItemGroup(projectElement);
            if (!hasGroupElement)
            {
                var output = this.Add_PackageReferenceItemGroup(projectElement);
                return output;
            }

            return hasGroupElement.Result;
        }

        public XAttribute Acquire_SdkAttribute(IProjectElement projectElement)
        {
            var sdkAttribute = projectElement.Value.Acquire_Attribute(
                Instances.ProjectElementNames.Sdk);

            return sdkAttribute;
        }

        public XAttribute Acquire_IncludeAttribute(XElement element)
        {
            var includeAttribute = element.Acquire_Attribute(
                Instances.ProjectElementNames.Include);

            return includeAttribute;
        }

        /// <summary>
        /// Creates a new COM references item group element, adds it to the project element, then returns the newly created and added item group element.
        /// </summary>
        /// <returns>The newly created and added item group element.</returns>
        public ICOMReferenceItemGroupElement Add_COMReferenceItemGroup(IProjectElement projectElement)
        {
            var groupElement = this.New_COMReferencesItemGroup();

            projectElement.Value.Add_Child(groupElement);

            return groupElement.ToCOMReferenceItemGroupElement();
        }

        public WasFound<XElement> Has_ItemGroup_WithChild(IProjectElement projectElement,
            IElementName grandChildName)
        {
            var output = projectElement.Value.Has_ChildWithChild(
                Instances.ProjectElementNames.ItemGroup,
                grandChildName);

            return output;
        }

        public WasFound<XElement> Has_LabeledItemGroup(
            IProjectElement projectElement,
            string labelValue)
        {
            var output = projectElement.Value.Has_Child_ByNameAndAttributeValue(
                Instances.ProjectElementNames.ItemGroup,
                Instances.ProjectElementNames.Label,
                labelValue);

            return output;
        }

        public WasFound<XElement> Has_LabeledItemGroup(
            IProjectElement projectElement,
            IGroupLabel groupLabel)
        {
            return this.Has_LabeledItemGroup(
                projectElement,
                groupLabel.Value);
        }

        public WasFound<XElement> Has_LabeledPropertyGroup(
            IProjectElement projectElement,
            string labelValue)
        {
            var output = projectElement.Value.Has_Child_ByNameAndAttributeValue(
                Instances.ProjectElementNames.PropertyGroup,
                Instances.ProjectElementNames.Label,
                labelValue);

            return output;
        }

        public WasFound<XElement> Has_LabeledPropertyGroup(
            IProjectElement projectElement,
            IGroupLabel groupLabel)
        {
            return this.Has_LabeledPropertyGroup(
                projectElement,
                groupLabel.Value);
        }

        public WasFound<ICOMReferenceItemGroupElement> Has_ComReferenceItemGroup(IProjectElement projectElement)
        {
            // A project element might have multiple item group elements.
            // So what is the "COM References" item group element anyway?
            // Here the COM references item group is defined via two methods:
            //  1. Is there an item group with a COMReference element?
            //  2. Is there an item group with a label attribute, with the COM references value?
            // Otherwise, there is no COM references item group element.
            // We don't take care if there is at least one item group. We want a COM references item group.


            // Is there an item group with a COM references element?
            var hasItemGroup = this.Has_ItemGroup_WithChild(
                projectElement,
                Instances.ProjectElementNames.COMReference);

            if (hasItemGroup)
            {
                return hasItemGroup
                    .Convert(propertyGroupElement => propertyGroupElement.ToCOMReferenceItemGroupElement());
            }

            // Is there an item group with a label attribute, with the COM references value?
            var hasLabeledItemGroup = this.Has_LabeledItemGroup(
                projectElement,
                Instances.GroupLabels.COMReferences);

            if (hasLabeledItemGroup != default)
            {
                return WasFound.Found(hasLabeledItemGroup.Result.ToCOMReferenceItemGroupElement());
            }

            // There is no item group, so return not found.
            var notFound = WasFound.NotFound<ICOMReferenceItemGroupElement>();
            return notFound;
        }

        public XElement New_PropertyGroup()
        {
            var output = new XElement(Instances.ProjectElementNames.PropertyGroup.Value);
            return output;
        }

        public XElement New_PropertyGroup(IGroupLabel propertyGroupLabel)
        {
            var propertyGroupElement = this.New_PropertyGroup();

            Instances.LabeledOperator.Add_LabelAttribute(
                propertyGroupElement,
                propertyGroupLabel.Value);

            return propertyGroupElement;
        }

        public XElement New_ItemGroup()
        {
            var output = new XElement(Instances.ProjectElementNames.ItemGroup.Value);
            return output;
        }

        public XElement New_ItemGroup(IGroupLabel itemGroupLabel)
        {
            var propertyGroupElement = this.New_ItemGroup();

            Instances.LabeledOperator.Add_LabelAttribute(
                propertyGroupElement,
                itemGroupLabel.Value);

            return propertyGroupElement;
        }

        public XElement New_CustomPropertyGroup()
        {
            var customPropertyGroupElement = this.New_PropertyGroup(Instances.GroupLabels.Custom);
            return customPropertyGroupElement;
        }

        public XElement New_MainPropertyGroup()
        {
            var mainPropertyGroupElement = this.New_PropertyGroup(Instances.GroupLabels.Main);
            return mainPropertyGroupElement;
        }

        public XElement New_PackagePropertyGroup()
        {
            var mainPropertyGroupElement = this.New_PropertyGroup(Instances.GroupLabels.Package);
            return mainPropertyGroupElement;
        }

        public XElement New_COMReferencesItemGroup()
        {
            var mainPropertyGroupElement = this.New_ItemGroup(Instances.GroupLabels.COMReferences);
            return mainPropertyGroupElement;
        }

        public XElement New_ProjectReferencesItemGroup()
        {
            var mainPropertyGroupElement = this.New_ItemGroup(Instances.GroupLabels.ProjectReferences);
            return mainPropertyGroupElement;
        }

        public WasFound<XElement> Has_MainPropertyGroup(IProjectElement projectElement)
        {
            // A project element might have multiple property group elements.
            // So what is the "main" property group element anyway?
            // Here the main property group is defined via three methods:
            //  1. Is there a property group with a target-framework element?
            //  2. Is there a property group with a label attribute, with the main value?
            //  3. Is there at least one property group? Take that one.
            // Otherwise, there is no main property group element.

            // Is there a property group with a target-framework element?
            var hasTargetFrameworkPropertyGroup = this.Has_PropertyGroup_WithChild(
                projectElement,
                Instances.ProjectElementNames.TargetFramework);

            if (hasTargetFrameworkPropertyGroup)
            {
                return hasTargetFrameworkPropertyGroup;
            }

            // Is there a property group with a label attribute, with the main value?
            var hasLabeledPropertyGroup = Instances.ProjectXmlOperator_Internal.Has_LabeledPropertyGroup(
                projectElement,
                Instances.GroupLabels.Main);

            if (hasLabeledPropertyGroup != default)
            {
                return WasFound.Found(hasLabeledPropertyGroup.Result);
            }

            // Is there at least one property group? Take the first.
            var firstPropertyGroupOrDefault = projectElement.Value.Get_Children()
                .Where_NameIs(Instances.ProjectElementNames.PropertyGroup)
                .FirstOrDefault();

            if (firstPropertyGroupOrDefault != default)
            {
                return WasFound.Found(firstPropertyGroupOrDefault);
            }

            // There is no main property group, so return not found.
            var notFound = WasFound.NotFound<XElement>();
            return notFound;
        }

        public WasFound<XElement> Has_MainPropertyGroupChild(
            IProjectElement projectElement,
            IElementName childName)
        {
            var hasMainPropertyGroup = this.Has_MainPropertyGroup(projectElement);

            var output = hasMainPropertyGroup.Convert(
                mainPropertyGroup => mainPropertyGroup.Has_Child(childName));

            return output;
        }

        public WasFound<IPackageReferenceItemGroupElement> Has_PackageReferenceItemGroup(IProjectElement projectElement)
        {
            // A project element might have multiple item group elements.
            // So what is the "Package References" item group element anyway?
            // Here the package references item group is defined via two methods:
            //  1. Is there an item group with a PackageReference element?
            //  2. Is there an item group with a label attribute, with the package references value?
            // Otherwise, there is no package references item group element.
            // We don't take care if there is at least one item group. We want a package references item group.


            // Is there an item group with a COM references element?
            var hasItemGroup = this.Has_ItemGroup_WithChild(
                projectElement,
                Instances.ProjectElementNames.PackageReference);

            if (hasItemGroup)
            {
                return hasItemGroup
                    .Convert(propertyGroupElement => propertyGroupElement.ToPackageReferenceItemGroupElement());
            }

            // Is there an item group with a label attribute, with the COM references value?
            var hasLabeledItemGroup = this.Has_LabeledItemGroup(
                projectElement,
                Instances.GroupLabels.PackageReferences);

            if (hasLabeledItemGroup != default)
            {
                return WasFound.Found(hasLabeledItemGroup.Result.ToPackageReferenceItemGroupElement());
            }

            // There is no item group, so return not found.
            var notFound = WasFound.NotFound<IPackageReferenceItemGroupElement>();
            return notFound;
        }

        public WasFound<XElement> Has_PropertyGroup_WithChild(
            IProjectElement projectElement,
            IElementName grandChildName)
        {
            var output = projectElement.Value.Has_ChildWithChild(
                Instances.ProjectElementNames.PropertyGroup,
                grandChildName);

            return output;
        }

        public XElement New_PackageReferencesItemGroup()
        {
            var mainPropertyGroupElement = this.New_ItemGroup(Instances.GroupLabels.PackageReferences);
            return mainPropertyGroupElement;
        }

        /// <summary>
        /// Creates a new pacakge references item group element, adds it to the project element, then returns the newly created and added item group element.
        /// </summary>
        /// <returns>The newly created and added item group element.</returns>
        public IPackageReferenceItemGroupElement Add_PackageReferenceItemGroup(IProjectElement projectElement)
        {
            var groupElement = this.New_PackageReferencesItemGroup();

            projectElement.Value.Add_Child(groupElement);

            return groupElement.ToPackageReferenceItemGroupElement();
        }

        public WasFound<ICopyToOutputItemGroupElement> Has_CopyToOutputItemGroup(IProjectElement projectElement)
        {
            // A project element might have multiple item group elements.
            // So what is the "Copy to Output" item group element anyway?
            // Here the copy-to-output references item group is defined via two methods:
            //  1. Is there an item group with a None element?
            //  2. Is there an item group with a label attribute, with the copy-to-output value?
            // Otherwise, there is no copy-to-output item group element.
            // We don't take care if there is at least one item group. We want a copy-to-output item group.


            // Is there an item group with a None element?
            var hasItemGroup = this.Has_ItemGroup_WithChild(
                projectElement,
                Instances.ProjectElementNames.None);

            if (hasItemGroup)
            {
                return hasItemGroup
                    .Convert(propertyGroupElement => propertyGroupElement.ToCopyToOutputItemGroupElement());
            }

            // Is there an item group with a label attribute, with the copy-to-output value?
            var hasLabeledItemGroup = this.Has_LabeledItemGroup(
                projectElement,
                Instances.GroupLabels.CopyToOutput);

            if (hasLabeledItemGroup != default)
            {
                return WasFound.Found(hasLabeledItemGroup.Result.ToCopyToOutputItemGroupElement());
            }

            // There is no item group, so return not found.
            var notFound = WasFound.NotFound<ICopyToOutputItemGroupElement>();
            return notFound;
        }

        public XElement New_CopyToOutputItemGroup()
        {
            var itemGroupElement = this.New_ItemGroup(Instances.GroupLabels.CopyToOutput);
            return itemGroupElement;
        }

        /// <summary>
        /// Creates a new pacakge references item group element, adds it to the project element, then returns the newly created and added item group element.
        /// </summary>
        /// <returns>The newly created and added item group element.</returns>
        public ICopyToOutputItemGroupElement Add_CopyToOutputItemGroup(IProjectElement projectElement)
        {
            var groupElement = this.New_CopyToOutputItemGroup();

            projectElement.Value.Add_Child(groupElement);

            return groupElement.ToCopyToOutputItemGroupElement();
        }

        public void Set_COMReferenceElement(
            IProjectElement projectElement,
            ICOMReferenceElement comReferenceElement,
            string comReferenceName)
        {
            var comReferencesItemGroup = this.Acquire_COMReferencesItemGroup(projectElement);

            var hasComReference = comReferencesItemGroup.Value.Has_Child_ByNameAndAttributeValue(
                Instances.ProjectElementNames.COMReference,
                Instances.ProjectElementNames.Include,
                comReferenceName);

            if(hasComReference)
            {
                hasComReference.Result.Remove();
            }

            comReferencesItemGroup.Value.Add_Child(comReferenceElement.Value);
        }

        public void Add_COMReferenceElement(
            IProjectElement projectElement,
            ICOMReferenceElement comReferenceElement)
        {
            var comReferencesItemGroup = this.Acquire_COMReferencesItemGroup(projectElement);

            comReferencesItemGroup.Value.Add_Child(comReferenceElement.Value);
        }

        public ICOMReferenceElement Get_COMReferenceElement(COMReference comReference)
        {
            var element = Instances.XElementOperator.New(Instances.ProjectElementNames.COMReference);

            element.SetAttributeValue(Instances.ProjectElementNames.Include.Value, comReference.Name);

            element.Add_Child(Instances.ProjectElementNames.WrapperTool, comReference.WrapperTool);
            element.Add_Child(Instances.ProjectElementNames.VersionMinor, comReference.Version_Minor.To_String_ForProjectXml());
            element.Add_Child(Instances.ProjectElementNames.VersionMajor, comReference.Version_Major.To_String_ForProjectXml());
            element.Add_Child(Instances.ProjectElementNames.Guid, comReference.Guid.To_String_ForCOMReference());
            element.Add_Child(Instances.ProjectElementNames.Lcid, comReference.Lcid.To_String_ForProjectXml());
            element.Add_Child(Instances.ProjectElementNames.Isolated, comReference.Isolated.To_String_ForProjectXml());
            element.Add_Child(Instances.ProjectElementNames.EmbedInteropTypes, comReference.EmbedInteropTypes.To_String_ForProjectXml());

            var output = element.ToCOMReferenceElement();
            return output;
        }

        public ICOMReferenceElement Add_COMReference(
            IProjectElement projectElement,
            COMReference comReference)
        {
            var comReferenceElement = this.Get_COMReferenceElement(comReference);

            this.Add_COMReferenceElement(
                projectElement,
                comReferenceElement);

            return comReferenceElement;
        }

        public IPackageReferenceElement Get_PackageReferenceElement(PackageReference packageReference)
        {
            var element = Instances.XElementOperator.New(Instances.ProjectElementNames.PackageReference);

            element.SetAttributeValue(
                Instances.ProjectElementNames.Include.Value,
                packageReference.Name.Value);

            var versionString = Instances.VersionOperator.ToString_ForProjectXml(packageReference.Version.Value);

            element.SetAttributeValue(
                Instances.ProjectElementNames.Version.Value,
                versionString);

            var output = element.ToPackageReferenceElement();
            return output;
        }

        public IPackageReferenceElement[] Get_PackageReferenceElements(IPackageReferenceItemGroupElement packageReferenceItemGroupElement)
        {
            var output = Instances.XElementOperator.Get_Children(
                packageReferenceItemGroupElement.Value,
                Instances.ProjectElementNames.PackageReference)
                .Select(element => element.ToPackageReferenceElement())
                .Now();

            return output;
        }

        public XElement Add_ItemGroup(IProjectElement projectElement)
        {
            var itemGroupElement = Instances.ProjectXmlOperator_Internal.New_ItemGroup();

            projectElement.Value.Add_Child(itemGroupElement);

            return itemGroupElement;
        }

        public IPackageReferenceElement Add_PackageReference(
            IProjectElement projectElement,
            PackageReference packageReference)
        {
            var packageReferenceElement = this.Get_PackageReferenceElement(packageReference);

            this.Add_PackageReferenceElement(
                projectElement,
                packageReferenceElement);

            return packageReferenceElement;
        }

        public Dictionary<PackageReference, IPackageReferenceElement> Add_PackageReferences(
            IProjectElement projectElement,
            IEnumerable<PackageReference> packageReferences)
        {
            var packageReferenceElementsByPackageReference = packageReferences
                .ToDictionary(
                    packageReference => packageReference,
                    packageReference => this.Get_PackageReferenceElement(packageReference));

            var itemGroup = this.Acquire_PackageReferencesItemGroup(projectElement);

            foreach (var packageReference in packageReferenceElementsByPackageReference.Values)
            {
                itemGroup.Value.Add_Child(packageReference.Value);
            }

            return packageReferenceElementsByPackageReference;
        }

        public void Add_PackageReferenceElement(
            IProjectElement projectElement,
            IPackageReferenceElement packageReferenceElement)
        {
            var itemGroup = this.Acquire_PackageReferencesItemGroup(projectElement);

            itemGroup.Value.Add_Child(packageReferenceElement.Value);
        }

        public IProjectReferenceElement Get_ProjectReferenceElement(IProjectDirectoryRelativePath projectReferenceRelativePath)
        {
            var element = Instances.XElementOperator.New(Instances.ProjectElementNames.ProjectReference);

            element.SetAttributeValue(
                Instances.ProjectElementNames.Include.Value,
                projectReferenceRelativePath.Value);

            var output = element.ToProjectReferenceElement();
            return output;
        }

        public ICopyToOutputElement Get_CopyToOutputElement(IProjectDirectoryRelativePath projectReferenceRelativePath)
        {
            var noneElement = Instances.XElementOperator.New(Instances.ProjectElementNames.None);

            noneElement.SetAttributeValue(
                Instances.ProjectElementNames.Update.Value,
                projectReferenceRelativePath.Value);

            var copyToOutputDirectoryElement = Instances.XElementOperator.New(
                Instances.ProjectElementNames.CopyToOutputDirectory);

            copyToOutputDirectoryElement.Value = Instances.CopyToOutputDirectives.CopyIfNewer.Value;

            noneElement.Add_Child(copyToOutputDirectoryElement);

            var output = noneElement.ToCopyToOutputElement();
            return output;
        }

        public (IProjectDirectoryRelativePath projectDirectoryRelativePath, ICopyToOutputElement copyToOutputElement)[] Add_CopyToOutputs(
            IProjectElement projectElement,
            IEnumerable<IProjectDirectoryRelativePath> fileRelativePaths)
        {
            var elementsByRelativePath = fileRelativePaths
                .Select(projectDirectoryRelativePath => (
                    projectDirectoryRelativePath,
                    copyToOutputElement: this.Get_CopyToOutputElement(projectDirectoryRelativePath)))
                .Now();

            var itemGroup = this.Acquire_CopyToOutputItemGroup(projectElement);

            foreach (var element in elementsByRelativePath
                .Select(x => x.copyToOutputElement))
            {
                itemGroup.Value.Add_Child(element.Value);
            }

            return elementsByRelativePath;
        }
    }
}
