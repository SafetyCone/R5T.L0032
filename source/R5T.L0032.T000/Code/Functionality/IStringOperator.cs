using System;

using R5T.T0132;


namespace R5T.L0032.T000
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ICopyToOutputDirective"/>
        public ICopyToOutputDirective ToCopyToOutputDirectoryDirective(string value)
        {
            var output = new CopyToOutputDirective(value);
            return output;
        }

        /// <inheritdoc cref="IGroupLabel"/>
        public IGroupLabel ToGroupLabel(string value)
        {
            var output = new GroupLabel(value);
            return output;
        }

        /// <inheritdoc cref="INugetUserName"/>
        public INugetUserName ToNugetUserName(string value)
        {
            var output = new NugetUserName(value);
            return output;
        }

        /// <inheritdoc cref="IOutputType"/>
        public IOutputType ToOutputType(string value)
        {
            var output = new OutputType(value);
            return output;
        }

        /// <inheritdoc cref="IPackageLicenseExpression"/>
        public IPackageLicenseExpression ToPackageLicenseExpression(string value)
        {
            var output = new PackageLicenseExpression(value);
            return output;
        }

        /// <inheritdoc cref="IProjectSdkName"/>
        public IProjectSdkName ToProjectSdkName(string value)
        {
            var output = new ProjectSdkName(value);
            return output;
        }

        /// <inheritdoc cref="ISupportedPlatform"/>
        public ISupportedPlatform ToSupportedPlatform(string value)
        {
            var output = new SupportedPlatform(value);
            return output;
        }
    }
}
