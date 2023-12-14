using System;
using System.Xml.Linq;

using R5T.N0000;
using R5T.T0132;

using R5T.L0032.T000;
using R5T.T0218;
using System.Collections.Generic;


namespace R5T.L0032.F001
{
    [FunctionalityMarker]
    public partial interface IPropertyGroupXElementOperator : IFunctionalityMarker
    {
        public XElement New_PropertyGroupXElement()
        {
            var propertyGroupElement = Instances.XElementOperator.New(
                Instances.ProjectNodeNames._Platform.PropertyGroup);

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
                Instances.ProjectNodeNames._Platform.Authors,
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
                Instances.ProjectNodeNames._Platform.Company,
                company);

            return companyElement;
        }

        public XElement Set_Copyright(
            XElement propertyGroupElement,
            string copyright)
        {
            var copyrightElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.Copyright,
                copyright);

            return copyrightElement;
        }

        public XElement Set_Description(
            XElement propertyGroupElement,
            string description)
        {
            var descriptionElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.Copyright,
                description);

            return descriptionElement;
        }

        public XElement Set_ImplicitUsings(
            XElement propertyGroupElement,
            string implicitUsingsValue)
        {
            var implicitUsingsElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.ImplicitUsings,
                implicitUsingsValue);

            return implicitUsingsElement;
        }

        public XElement Set_ImplicitUsings(
            XElement propertyGroupElement,
            Enabled enabled)
        {
            var implicitUsingsValue = Instances.EnabledOperator.To_String(enabled);

            return this.Set_ImplicitUsings(
                propertyGroupElement,
                implicitUsingsValue);
        }

        public XElement Set_Nullable(
            XElement propertyGroupElement,
            string nullableValue)
        {
            var nullableElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.Nullable,
                nullableValue);

            return nullableElement;
        }

        public XAttribute Set_Label(
            XElement propertyGroupElement,
            string label)
        {
            return Instances.ProjectXElementsOperator.Set_Label(
                propertyGroupElement,
                label);
        }

        public XAttribute Set_Label(
            XElement propertyGroupElement,
            IGroupLabel groupLabel)
        {
            return Instances.ProjectXElementsOperator.Set_Label(
                propertyGroupElement,
                groupLabel);
        }

        public XElement Set_Nullable(
            XElement propertyGroupElement,
            T000.Nullable nullable)
        {
            var nullableValue = Instances.NullableOperator.To_String(nullable);

            return this.Set_Nullable(
                propertyGroupElement,
                nullableValue);
        }

        public XElement Set_OutputType(
            XElement propertyGroupElement,
            string outputTypeValue)
        {
            var outputTypeElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.OutputType,
                outputTypeValue);

            return outputTypeElement;
        }

        public XElement Set_OutputType(
            XElement propertyGroupElement,
            IOutputType outputType)
        {
            return this.Set_OutputType(
                propertyGroupElement,
                outputType.Value);
        }

        public XElement Set_TargetFramework(
            XElement propertyGroupElement,
            string targetFrameworkValue)
        {
            var targetFrameworkElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.TargetFramework,
                targetFrameworkValue);

            return targetFrameworkElement;
        }

        public XElement Set_PackageLicenseExpression(
            XElement propertyGroupElement,
            string packageLicenseExpression)
        {
            var packageLicenseExpressionElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.PackageLicenseExpression,
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
                Instances.ProjectNodeNames._Platform.PackageRequireLicenseAcceptance,
                valueString);

            return packageRequireLicenseAcceptanceElement;
        }

        public XElement Set_RepositoryUrl(
            XElement propertyGroupElement,
            string repositoryUrl)
        {
            var repositoryUrlElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.RepositoryUrl,
                repositoryUrl);

            return repositoryUrlElement;
        }

        public XElement Set_TargetFramework(
            XElement propertyGroupElement,
            ITargetFrameworkMoniker targetFrameworkMoniker)
        {
            return this.Set_TargetFramework(
                propertyGroupElement,
                targetFrameworkMoniker.Value);
        }

        public XElement Set_Version(
            XElement propertyGroupElement,
            string versionString)
        {
            var versionElement = Instances.XElementOperator.Set_ChildValue(
                propertyGroupElement,
                Instances.ProjectNodeNames._Platform.Version,
                versionString);

            return versionElement;
        }

        public XElement Set_Version(
            XElement propertyGroupElement,
            Version version)
        {
            var versionString = Instances.VersionOperator.ToString_ForProjectXml(version);

            return this.Set_Version(
                propertyGroupElement,
                versionString);
        }
    }
}
