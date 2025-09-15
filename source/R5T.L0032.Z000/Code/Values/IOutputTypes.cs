using System;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;
using R5T.T0131;
using R5T.T0143;


namespace R5T.L0032.Z000
{
    [ValuesMarker]
    public partial interface IOutputTypes : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z001.IOutputTypes _Platform => Z001.OutputTypes.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="F10Y.L0006.Z000.IOutputTypes.Default"/>
        public IOutputType Default => this.Library;

        /// <inheritdoc cref="F10Y.L0006.Z000.IOutputTypes.Exe"/>
        public IOutputType Exe => _Platform.Exe.ToOutputType();

        /// <inheritdoc cref="F10Y.L0006.Z000.IOutputTypes.Library"/>
        public IOutputType Library => _Platform.Library.ToOutputType();

        /// <inheritdoc cref="F10Y.L0006.Z000.IOutputTypes.Module"/>
        public IOutputType Module => _Platform.Module.ToOutputType();

        /// <inheritdoc cref="F10Y.L0006.Z000.IOutputTypes.WinExe"/>
        public IOutputType WinExe => _Platform.WinExe.ToOutputType();
    }
}
