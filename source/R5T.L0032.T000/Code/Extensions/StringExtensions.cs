using System;


namespace R5T.L0032.T000.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToCopyToOutputDirectoryDirective(string)"/>
        public static ICopyToOutputDirective ToCopyToOutputDirectoryDirective(this string value)
        {
            return Instances.StringOperator.ToCopyToOutputDirectoryDirective(value);
        }

        /// <inheritdoc cref="IStringOperator.ToGroupLabel(string)"/>
        public static IGroupLabel ToGroupLabel(this string value)
        {
            return Instances.StringOperator.ToGroupLabel(value);
        }

        /// <inheritdoc cref="IStringOperator.ToNugetUserName(string)"/>
        public static INugetUserName ToNugetUserName(this string value)
        {
            return Instances.StringOperator.ToNugetUserName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToOutputType(string)"/>
        public static IOutputType ToOutputType(this string value)
        {
            return Instances.StringOperator.ToOutputType(value);
        }

        /// <inheritdoc cref="IStringOperator.ToPackageLicenseExpression(string)"/>
        public static IPackageLicenseExpression ToPackageLicenseExpression(this string value)
        {
            return Instances.StringOperator.ToPackageLicenseExpression(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectSdkName(string)"/>
        public static IProjectSdkName ToProjectSdkName(this string value)
        {
            return Instances.StringOperator.ToProjectSdkName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSupportedPlatform(string)"/>
        public static ISupportedPlatform ToSupportedPlatform(this string value)
        {
            return Instances.StringOperator.ToSupportedPlatform(value);
        }
    }
}
