using System;

using R5T.F0120.Extensions;
using R5T.T0132;


namespace R5T.L0032.T000
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ICopyToOutputDirective ToCopyToOutputDirectoryDirective(string value)
        {
            var output = new CopyToOutputDirective(value);
            return output;
        }

        public IGroupLabel ToGroupLabel(string value)
        {
            var output = new GroupLabel(value);
            return output;
        }

        public INugetUserName ToNugetUserName(string value)
        {
            var output = new NugetUserName(value);
            return output;
        }

        public IOutputType ToOutputType(string value)
        {
            var output = new OutputType(value);
            return output;
        }

        public IPackageLicenseExpression ToPackageLicenseExpression(string value)
        {
            var output = new PackageLicenseExpression(value);
            return output;
        }

        public IProjectSdkName ToProjectSdkName(string value)
        {
            var output = new ProjectSdkName(value);
            return output;
        }

        public ITargetFrameworkMoniker ToTargetFrameworkMoniker(string value)
        {
            var output = new TargetFrameworkMoniker(value);
            return output;
        }
    }
}
