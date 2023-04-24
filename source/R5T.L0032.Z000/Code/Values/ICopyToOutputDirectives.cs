using System;
using R5T.T0131;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;


namespace R5T.L0032.Z000
{
    [ValuesMarker]
    public partial interface ICopyToOutputDirectives : IValuesMarker
    {
        public ICopyToOutputDirective CopyIfNewer => "PreserveNewest".ToCopyToOutputDirectoryDirective();
        public ICopyToOutputDirective DoNotCopy => "Never".ToCopyToOutputDirectoryDirective();
        public ICopyToOutputDirective CopyAlways => "Always".ToCopyToOutputDirectoryDirective();
    }
}
