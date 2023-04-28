using System;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;
using R5T.T0131;


namespace R5T.L0032.Z000
{
    [ValuesMarker]
    public partial interface IOutputTypes : IValuesMarker
    {
        /// <summary>
        /// Library - The default value if not presen in the project.
        /// </summary>
        public IOutputType Default => this.Library;

        /// <summary>
        /// Exe - Creates a console application.
        /// </summary>
        public IOutputType Exe => "Exe".ToOutputType();

        /// <summary>
        /// Library - Creates a code library.
        /// </summary>
        public IOutputType Library => "Library".ToOutputType();

        /// <summary>
        /// Module - Creates a module.
        /// </summary>
        public IOutputType Module => "Module".ToOutputType();

        /// <summary>
        /// WinExe - Creates a module.
        /// </summary>
        public IOutputType WinExe => "WinExe".ToOutputType();
    }
}
