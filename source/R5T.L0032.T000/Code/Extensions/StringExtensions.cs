using System;


namespace R5T.L0032.T000.Extensions
{
    public static class StringExtensions
    {
        public static ICopyToOutputDirective ToCopyToOutputDirectoryDirective(this string value)
        {
            return Instances.StringOperator.ToCopyToOutputDirectoryDirective(value);
        }

        public static IGroupLabel ToGroupLabel(this string value)
        {
            return Instances.StringOperator.ToGroupLabel(value);
        }

        public static INugetUserName ToNugetUserName(this string value)
        {
            return Instances.StringOperator.ToNugetUserName(value);
        }

        public static IOutputType ToOutputType(this string value)
        {
            return Instances.StringOperator.ToOutputType(value);
        }

        public static IPackageLicenseExpression ToPackageLicenseExpression(this string value)
        {
            return Instances.StringOperator.ToPackageLicenseExpression(value);
        }

        public static IPackageName ToPackageName(this string value)
        {
            return Instances.StringOperator.ToPackageName(value);
        }

        public static IProjectSdkName ToProjectSdkName(this string value)
        {
            return Instances.StringOperator.ToProjectSdkName(value);
        }

        public static IPackageVersion ToPackageVersion(this string value)
        {
            return Instances.StringOperator.ToPackageVersion(value);
        }

        public static IRepositoryUrl ToRepositoryUrl(this string value)
        {
            return Instances.StringOperator.ToRepositoryUrl(value);
        }

        public static ITargetFrameworkMoniker ToTargetFrameworkMoniker(this string value)
        {
            return Instances.StringOperator.ToTargetFrameworkMoniker(value);
        }
    }
}
