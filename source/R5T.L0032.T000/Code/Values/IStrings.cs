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
        /// <para><value>"disabled"</value></para>
        /// </summary>
        public string Disabled => "disabled";

        /// <summary>
        /// <para><value>"enabled"</value></para>
        /// </summary>
        public string Enabled => "enabled";

        /// <summary>
        /// <para><value>"warnings"</value></para>
        /// </summary>
        public string Warnings => "warnings";
    }
}
