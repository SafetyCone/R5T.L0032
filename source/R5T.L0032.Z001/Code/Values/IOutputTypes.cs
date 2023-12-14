using System;

using R5T.T0131;


namespace R5T.L0032.Z001
{
    [ValuesMarker]
    public partial interface IOutputTypes : IValuesMarker
    {
        /// <summary>
        /// Library - The assumed output type if an output type node is not present in a project element.
        /// </summary>
        public string Default => this.Library;

        /// <summary>
        /// Exe - Creates a console application.
        /// </summary>
        public string Exe => "Exe";

        /// <summary>
        /// Library - Creates a code library.
        /// </summary>
        public string Library => "Library";

        /// <summary>
        /// Module - Creates a module.
        /// <para>(Unclear what a "module" is...)</para>
        /// </summary>
        public string Module => "Module";

        /// <summary>
        /// WinExe - Creates a module.
        /// </summary>
        public string WinExe => "WinExe";
    }
}
