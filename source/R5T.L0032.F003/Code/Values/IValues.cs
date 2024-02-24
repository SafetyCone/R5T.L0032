using System;

using R5T.T0131;


namespace R5T.L0032.F003
{
    /// <summary>
    /// Common project element values.
    /// </summary>
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        public char AuthorsListSeparator_Character => Instances.Characters.Semicolon;

        /// <summary>
        /// <para><value>"--- ADD DESCRIPTION ---"</value></para>
        /// </summary>
        public string DescriptionForProject_Default => "--- ADD DESCRIPTION ---";

        /// <summary>
        /// <para><value>"--- EXAMPLE DESCRIPTION ---"</value></para>
        /// </summary>
        public string DescriptionForProject_Example => "--- EXAMPLE DESCRIPTION ---";
    }
}
