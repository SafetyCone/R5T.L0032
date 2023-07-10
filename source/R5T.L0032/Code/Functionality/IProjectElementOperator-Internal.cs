using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

using R5T.F0000;
using R5T.L0030.Extensions;
using R5T.L0030.T000;
using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;
using R5T.T0132;
using R5T.T0202;


namespace R5T.L0032.Internal
{
    [FunctionalityMarker]
    public partial interface IProjectElementOperator : IFunctionalityMarker
    {
        public ICustomPropertyGroupElement Acquire_CustomPropertyGroup(IProjectElement projectElement)
        {
            var hasCustomPropertyGroupElement = this.Has_CustomPropertyGroup(projectElement);
            if (!hasCustomPropertyGroupElement)
            {
                var output = this.Add_CustomPropertyGroup(projectElement);
                return output;
            }

            return hasCustomPropertyGroupElement.Result;
        }

        public IMainPropertyGroupElement Acquire_MainPropertyGroup(IProjectElement projectElement)
        {
            var hasMainPropertyGroupElement = this.Has_MainPropertyGroup(projectElement);
            if (!hasMainPropertyGroupElement)
            {
                var output = this.Add_MainPropertyGroup(projectElement);
                return output;
            }

            return hasMainPropertyGroupElement.Result;
        }

        public IPackagePropertyGroupElement Acquire_PackagePropertyGroup(IProjectElement projectElement)
        {
            var hasPackageGroupElement = this.Has_PackagePropertyGroup(projectElement);
            if (!hasPackageGroupElement)
            {
                var output = this.Add_PackagePropertyGroup(projectElement);
                return output;
            }

            return hasPackageGroupElement.Result;
        }

        public IItemGroupElement Acquire_ItemGroup(
            IProjectElement projectElement,
            IElementName childName)
        {
            var hasItemGroup = this.Has_ItemGroup_WithChild(
                projectElement,
                childName);

            if(!hasItemGroup)
            {
                var output = this.Add_ItemGroup(projectElement);
                return output;
            }

            return hasItemGroup.Result;
        }

        /// <summary>
        /// Creates a new custom property group element, adds it to the project element, then returns the newly created and added property group element.
        /// </summary>
        /// <returns>The newly created and added main property group element.</returns>
        public ICustomPropertyGroupElement Add_CustomPropertyGroup(IProjectElement projectElement)
        {
            var customPropertyGroupElement = Instances.ProjectXmlOperator_Internal.New_CustomPropertyGroup();

            projectElement.Value.Add_Child(customPropertyGroupElement);

            return customPropertyGroupElement.ToCustomPropertyGroupElement();
        }

        /// <summary>
        /// Creates a new main property group element, adds it to the project element, then returns the newly created and added property group element.
        /// </summary>
        /// <returns>The newly created and added main property group element.</returns>
        public IMainPropertyGroupElement Add_MainPropertyGroup(IProjectElement projectElement)
        {
            var mainPropertyGroupElement = Instances.ProjectXmlOperator_Internal.New_MainPropertyGroup();

            projectElement.Value.Add_Child(mainPropertyGroupElement);

            return mainPropertyGroupElement.ToMainPropertyGroupElement();
        }

        /// <summary>
        /// Creates a new package property group element, adds it to the project element, then returns the newly created and added property group element.
        /// </summary>
        /// <returns>The newly created and added package property group element.</returns>
        public IPackagePropertyGroupElement Add_PackagePropertyGroup(IProjectElement projectElement)
        {
            var propertyGroupElement = Instances.ProjectXmlOperator_Internal.New_PackagePropertyGroup();

            projectElement.Value.Add_Child(propertyGroupElement);

            return propertyGroupElement.ToPackagePropertyGroupElement();
        }

        public IItemGroupElement Add_ItemGroup(IProjectElement projectElement)
        {
            var output = Instances.ProjectXmlOperator_Internal.Add_ItemGroup(projectElement)
                .ToItemGroupElement();

            return output;
        }

        public WasFound<ICustomPropertyGroupElement> Has_CustomPropertyGroup(IProjectElement projectElement)
        {
            // Is there a property group with a label attribute, with the main value?
            var hasLabeledPropertyGroup = Instances.ProjectXmlOperator_Internal.Has_LabeledPropertyGroup(
                projectElement,
                Instances.GroupLabels.Custom);

            if (hasLabeledPropertyGroup != default)
            {
                return WasFound.Found(hasLabeledPropertyGroup.Result.ToCustomPropertyGroupElement());
            }

            // Else, return not found.
            return WasFound.NotFound<ICustomPropertyGroupElement>();
        }

        public WasFound<IMainPropertyGroupElement> Has_MainPropertyGroup(IProjectElement projectElement)
        {
            var output = Instances.ProjectXmlOperator_Internal.Has_MainPropertyGroup(projectElement)
                .Convert(mainPropertyGroupElement => mainPropertyGroupElement.ToMainPropertyGroupElement());

            return output;
        }

        public WasFound<IPackagePropertyGroupElement> Has_PackagePropertyGroup(IProjectElement projectElement)
        {
            // A project element might have multiple property group elements.
            // So what is the "package" property group element anyway?
            // Here the package property group is defined via two methods:
            //  1. Is there a property group with a version element?
            //  2. Is there a property group with a label attribute, with the package value?
            // Otherwise, there is no main property group element.
            // We don't take care if there is at least one property group, since that will be the main property group. We want a version property group.


            // Is there a property group with a version element?
            var hasVersionPropertyGroup = this.Has_PropertyGroup_WithChild(
                projectElement,
                Instances.ProjectElementNames.Version);

            if (hasVersionPropertyGroup)
            {
                return hasVersionPropertyGroup
                    .Convert(propertyGroupElement => propertyGroupElement.Value.ToPackagePropertyGroupElement());
            }

            // Is there a property group with a label attribute, with the package value?
            var hasLabeledPropertyGroup = Instances.ProjectXmlOperator_Internal.Has_LabeledPropertyGroup(
                projectElement,
                Instances.GroupLabels.Package);

            if (hasLabeledPropertyGroup != default)
            {
                return WasFound.Found(hasLabeledPropertyGroup.Result.ToPackagePropertyGroupElement());
            }

            // There is no package property group, so return not found.
            var notFound = WasFound.NotFound<IPackagePropertyGroupElement>();
            return notFound;
        }

        public WasFound<IItemGroupElement> Has_ItemGroup_WithChild(
            IProjectElement projectElement,
            IElementName childName)
        {
            var output = Instances.ProjectXmlOperator_Internal.Has_ItemGroup_WithChild(
                projectElement,
                childName)
                .Convert(element => element.ToItemGroupElement());

            return output;
        }

        public WasFound<IPropertyGroupElement> Has_PropertyGroup_WithChild(
            IProjectElement projectElement,
            IElementName grandChildName)
        {
            var output = Instances.ProjectXmlOperator_Internal.Has_PropertyGroup_WithChild(
                projectElement,
                grandChildName)
                .Convert(element => element.ToPropertyGroupElement());

            return output;
        }

        /// <summary>
		/// Gets the property group element with the specified child element, if it exists.
		/// </summary>
		public WasFound<XElement> Has_PropertyGroup_WithChildElement(IProjectElement projectElement,
            string propertyGroupChildElementName)
        {
            // Assume just one property group with the element name.
            var wasFound = Instances.XElementOperator.HasChildWithChild_Single(
                projectElement.Value,
                Instances.ProjectElementNames.PropertyGroup.Value,
                propertyGroupChildElementName);

            return wasFound;
        }

        public WasFound<XElement> Has_PropertyGroup_ChildElement(IProjectElement projectElement,
            string propertyGroupIdentifyingChildElementName,
            string propertyGroupChildElementName)
        {
            var propertyGroupWithChildWasFound = this.Has_PropertyGroup_WithChildElement(
                projectElement,
                propertyGroupIdentifyingChildElementName);

            if (!propertyGroupWithChildWasFound)
            {
                return WasFound.NotFound<XElement>();
            }

            var propertyGroup = propertyGroupWithChildWasFound.Result;

            var child = propertyGroup.HasChild(propertyGroupChildElementName);
            return child;
        }

        public WasFound<XElement> Has_PropertyGroup_ChildElement(IProjectElement projectElement,
            string propertyGroupChildElementName)
        {
            var hasPropertyGroupChildElement = this.Has_PropertyGroup_ChildElement(projectElement,
                propertyGroupChildElementName,
                propertyGroupChildElementName);

            return hasPropertyGroupChildElement;
        }

        public WasFound<string> Has_PropertyGroup_ChildElementValue(IProjectElement projectElement,
            string propertyGroupChildElementName)
        {
            var hasPropertyGroupChildElement = this.Has_PropertyGroup_ChildElement(projectElement,
                propertyGroupChildElementName);

            var valueWasFound = hasPropertyGroupChildElement.Convert(x => x.Value);
            return valueWasFound;
        }

        public WasFound<string> Has_MainPropertyGroupElementValue(
            IProjectElement projectElement,
            IElementName childPropertyElementName)
        {
            var hasMainPropertyGroup = this.Has_MainPropertyGroup(projectElement);
            if(!hasMainPropertyGroup)
            {
                return WasFound.NotFound<string>();
            }

            var hasChildPropertyElement = Instances.XElementOperator.HasChild(
                hasMainPropertyGroup.Result.Value,
                childPropertyElementName.Value);

            var output = hasChildPropertyElement.Convert(element => Instances.XElementOperator.Get_Value(element));
            return output;
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

        public void Set_ItemGroupElementValue(
            IProjectElement projectElement,
            IElementName childName,
            string value)
        {
            var itemGroup = this.Acquire_ItemGroup(
                projectElement,
                childName);

            var childElement = itemGroup.Value.Acquire_Child(childName);

            Instances.XmlOperator.Set_Value(
                childElement,
                value);
        }
    }
}
