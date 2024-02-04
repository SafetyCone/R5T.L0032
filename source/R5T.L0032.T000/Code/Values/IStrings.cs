using System;

using R5T.T0131;


namespace R5T.L0032.T000
{
    [ValuesMarker]
    public partial interface IStrings : IValuesMarker
    {
        /// <summary>
        /// <para><value>"enabled"</value></para>
        /// </summary>
        public string Annotations => "annotations";

        /// <summary>
        /// <para><value>"disable"</value></para>
        /// </summary>
        public string Disable => "disable";

        /// <summary>
        /// <para><value>"enable"</value></para>
        /// </summary>
        public string Enable => "enable";

        /// <summary>
        /// <para><value>"warnings"</value></para>
        /// </summary>
        public string Warnings => "warnings";
    }
}
