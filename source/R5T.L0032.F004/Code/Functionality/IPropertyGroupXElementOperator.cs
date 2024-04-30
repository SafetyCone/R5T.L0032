using System;
using System.Collections.Generic;
using System.Xml.Linq;
using R5T.T0132;

using IProjectElementValues = R5T.L0032.Z001.IValues;


namespace R5T.L0032.F004
{
    /// <summary>
    /// Contains operations related the the property group element in Visual Studio (MSBuild) XML project files.
    /// </summary>
    /// <remarks>
    /// These operations should all be defined first in <see cref="IProjectXElementsOperator"/>, then retailed here.
    /// </remarks>
    [FunctionalityMarker]
    public partial interface IPropertyGroupXElementOperator : IFunctionalityMarker
    {
        public XElement New_PropertyGroupXElement()
        {
            var output = Instances.ProjectXElementsOperator.New_PropertyGroupXElement();
            return output;
        }

        /// <inheritdoc cref="IProjectXElementsOperator.Set_Authors(XElement, string)"/>
        public XElement Set_Authors(
            XElement propertyGroupElement,
            string authorsValue)
        {
            var output = Instances.ProjectXElementsOperator.Set_Authors(
                propertyGroupElement,
                authorsValue);

            return output;
        }

        /// <inheritdoc cref="IProjectXElementsOperator.Set_Authors(XElement, IEnumerable{string})"/>
        public XElement Set_Authors(
            XElement propertyGroupElement,
            IEnumerable<string> authors)
        {
            var output = Instances.ProjectXElementsOperator.Set_Authors(
                propertyGroupElement,
                authors);

            return output;
        }

        /// <inheritdoc cref="IProjectXElementsOperator.Set_Authors(XElement, string[])"/>
        public XElement Set_Authors(
            XElement propertyGroupElement,
            params string[] authors)
        {
            var output = Instances.ProjectXElementsOperator.Set_Authors(
                propertyGroupElement,
                authors);

            return output;
        }

        public XElement Set_Company(
            XElement propertyGroupElement,
            string company)
        {
            var output = Instances.ProjectXElementsOperator.Set_Company(
                propertyGroupElement,
                company);

            return output;
        }

        public XElement Set_Copyright(
            XElement propertyGroupElement,
            string copyright)
        {
            var output = Instances.ProjectXElementsOperator.Set_Copyright(
                propertyGroupElement,
                copyright);

            return output;
        }

        public XElement Set_Description(
            XElement propertyGroupElement,
            string description)
        {
            var output = Instances.ProjectXElementsOperator.Set_Description(
                propertyGroupElement,
                description);

            return output;
        }

        public XElement Set_ImplicitUsings(
            XElement propertyGroupElement,
            string implicitUsingsValue)
        {
            var output = Instances.ProjectXElementsOperator.Set_ImplicitUsings(
                propertyGroupElement,
                implicitUsingsValue);

            return output;
        }

        public XAttribute Set_Label(
            XElement labelAttributedElement,
            string label)
        {
            var output = Instances.ProjectXElementsOperator.Set_Label(
                labelAttributedElement,
                label);

            return output;
        }

        public XElement Set_StaticWebAssetProjectMode(
            XElement propertyGroupElement,
            // Only the "Default" value is supported for Blazor WebAssembly projects (which are the main consumer of this setting).
            string valueString = IProjectElementValues.Default_Constant)
        {
            var output = Instances.ProjectXElementsOperator.Set_StaticWebAssetProjectMode(
                propertyGroupElement,
                valueString);

            return output;
        }

        public XElement Set_WasmEnableWebcli(
            XElement propertyGroupElement,
            string valueString)
        {
            var output = Instances.ProjectXElementsOperator.Set_WasmEnableWebcli(
                propertyGroupElement,
                valueString);

            return output;
        }

        public XElement Set_WasmEnableWebcli(
            XElement propertyGroupElement,
            bool value = false)
        {
            var valueString = Instances.BooleanOperator.To_String_ForProjectXml(value);

            var output = this.Set_WasmEnableWebcli(
                propertyGroupElement,
                valueString);

            return output;
        }

        public XElement Set_NoDefaultLaunchSettingsFile(
            XElement propertyGroupElement,
            // Setting this at all means you probably want it to be true.
            bool value = true)
        {
            var output = Instances.ProjectXElementsOperator.Set_NoDefaultLaunchSettingsFile(
                propertyGroupElement,
                value);

            return output;
        }

        public XElement Set_NoWarn(
            XElement propertyGroupElement,
            string warningNumbersList)
        {
            var output = Instances.ProjectXElementsOperator.Set_NoWarn(
                propertyGroupElement,
                warningNumbersList);

            return output;
        }

        public XElement Set_Nullable(
            XElement propertyGroupElement,
            string nullableValue)
        {
            var output = Instances.ProjectXElementsOperator.Set_Nullable(
                propertyGroupElement,
                nullableValue);

            return output;
        }

        public XElement Set_OutputType(
            XElement propertyGroupElement,
            string outputTypeValue)
        {
            var output = Instances.ProjectXElementsOperator.Set_OutputType(
                propertyGroupElement,
                outputTypeValue);

            return output;
        }

        public XElement Set_PackageLicenseExpression(
            XElement propertyGroupElement,
            string packageLicenseExpression)
        {
            var output = Instances.ProjectXElementsOperator.Set_PackageLicenseExpression(
                propertyGroupElement,
                packageLicenseExpression);

            return output;
        }

        public XElement Set_PackageRequireLicenseAcceptance(
            XElement propertyGroupElement,
            bool value)
        {
            var output = Instances.ProjectXElementsOperator.Set_PackageRequireLicenseAcceptance(
                propertyGroupElement,
                value);

            return output;
        }

        public XElement Set_RepositoryUrl(
            XElement propertyGroupElement,
            string repositoryUrl)
        {
            var output = Instances.ProjectXElementsOperator.Set_RepositoryUrl(
                propertyGroupElement,
                repositoryUrl);

            return output;
        }

        public XElement Set_TargetFramework(
            XElement propertyGroupElement,
            string targetFrameworkValue)
        {
            var output = Instances.ProjectXElementsOperator.Set_TargetFramework(
                propertyGroupElement,
                targetFrameworkValue);

            return output;
        }

        public XElement Set_UseWindowsForms(
            XElement propertyGroupElement,
            string valueString)
        {
            var output = Instances.ProjectXElementsOperator.Set_UseWindowsForms(
                propertyGroupElement,
                valueString);

            return output;
        }

        public XElement Set_UseWindowsForms(
            XElement propertyGroupElement,
            bool value = true)
        {
            var output = Instances.ProjectXElementsOperator.Set_UseWindowsForms(
                propertyGroupElement,
                value);

            return output;
        }

        public XElement Set_Version(
            XElement propertyGroupElement,
            string versionString)
        {
            var output = Instances.ProjectXElementsOperator.Set_Version_ForPropertyGroup(
                propertyGroupElement,
                versionString);

            return output;
        }

        public XElement Set_Version(
            XElement propertyGroupElement,
            Version version)
        {
            var output = Instances.ProjectXElementsOperator.Set_Version_ForPropertyGroup(
                propertyGroupElement,
                version);

            return output;
        }
    }
}
