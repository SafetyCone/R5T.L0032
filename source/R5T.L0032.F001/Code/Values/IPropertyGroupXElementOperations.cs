using System;
using System.Xml.Linq;

using R5T.T0131;
using R5T.T0218;
using R5T.T0221;

using R5T.L0032.T000;


namespace R5T.L0032.F001
{
    [ValuesMarker]
    public partial interface IPropertyGroupXElementOperations : IValuesMarker
    {
        public Action<XElement> Enable_ImplicitUsings =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_ImplicitUsings(
                propertyGroupElement,
                Enabled.Enabled);

        public Action<XElement> Enable_Nullable =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Nullable(
                propertyGroupElement,
                T000.Nullable.Enabled);

        public Action<XElement> Set_Authors(params string[] authors) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Authors(
                propertyGroupElement,
                authors);

        public Action<XElement> Set_Company(string company) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Company(
                propertyGroupElement,
                company);

        public Action<XElement> Set_Copyright(string copyright) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Copyright(
                propertyGroupElement,
                copyright);

        public Action<XElement> Set_Description(string description) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Description(
                propertyGroupElement,
                description);

        public Action<XElement> Set_Description_Default =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Description(
                propertyGroupElement,
                Instances.Values.DescriptionForProject_Default);

        public Action<XElement> Set_ImplicitUsings(Enabled enabled) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_ImplicitUsings(
                propertyGroupElement,
                enabled);

        public Action<XElement> Set_Label(string label) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Label(
                propertyGroupElement,
                label);

        public Action<XElement> Set_Label(IGroupLabel groupLabel) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Label(
                propertyGroupElement,
                groupLabel);

        public Action<XElement> Set_OutputType(IOutputType outputType) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_OutputType(
                propertyGroupElement,
                outputType);

        public Action<XElement> Set_NoDefaultLaunchSettingsFile =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_NoDefaultLaunchSettingsFile(
                propertyGroupElement);

        /// <inheritdoc cref="Z001.IOutputTypes.Exe"/>
        public Action<XElement> Set_OutputType_Exe =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_OutputType(
                propertyGroupElement,
                Instances.OutputTypes.Exe);

        /// <inheritdoc cref="Z001.IValues.Default"/>
        public Action<XElement> Set_StaticWebAssetProjectMode_Default =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_StaticWebAssetProjectMode(
                propertyGroupElement,
                Instances.Values.Default);

        public Action<XElement> Set_TargetFramework(ITargetFrameworkMoniker targetFrameworkMoniker) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_TargetFramework(
                propertyGroupElement,
                targetFrameworkMoniker);

        public Action<XElement> Set_PackageLicenseExpression(string packageLicenseExpression) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_PackageLicenseExpression(
                propertyGroupElement,
                packageLicenseExpression);

        public Action<XElement> Set_PackageLicenseExpression_MIT =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_PackageLicenseExpression(
                propertyGroupElement,
                Instances.PackageLicenseExpressions.MIT.Value);

        public Action<XElement> Set_PackageRequireLicenseAcceptanceValue(bool value) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_PackageRequireLicenseAcceptance(
                propertyGroupElement,
                value);

        /// <summary>
        /// The default value is true.
        /// (Why would you be calling this otherwise?)
        /// </summary>
        public Action<XElement> Set_PackageRequireLicenseAcceptance =>
            this.Set_PackageRequireLicenseAcceptanceValue(true);

        public Action<XElement> Set_RepositoryUrl(string repositoryUrl) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_RepositoryUrl(
                propertyGroupElement,
                repositoryUrl);

        /// <inheritdoc cref="Z0057.ITargetFrameworkMonikers.Default"/>
        public Action<XElement> Set_TargetFramework_Default =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_TargetFramework(
                propertyGroupElement,
                Instances.TargetFrameworkMonikers.Default);

        /// <inheritdoc cref="Z0057.ITargetFrameworkMonikers.NET_8"/>
        public Action<XElement> Set_TargetFramework_Net8 =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_TargetFramework(
                propertyGroupElement,
                Instances.TargetFrameworkMonikers.NET_8);

        public Action<XElement> Set_Version(string versionString) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Version(
                propertyGroupElement,
                versionString);

        public Action<XElement> Set_Version(Version version) =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Version(
                propertyGroupElement,
                version);

        public Action<XElement> Set_Version_Initial_Default =>
            propertyGroupElement => Instances.PropertyGroupXElementOperator.Set_Version(
                propertyGroupElement,
                Instances.Versions.Initial_Default);
    }
}
