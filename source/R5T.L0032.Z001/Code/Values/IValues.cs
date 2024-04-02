using System;

using R5T.T0131;


namespace R5T.L0032.Z001
{
    /// <summary>
    /// Common project element values.
    /// </summary>
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        /// <summary>
        /// <para><value>Default</value></para>
        /// </summary>
        public const string Default_Constant = "Default";

        /// <inheritdoc cref="Default_Constant"/>
        public string Default => IValues.Default_Constant;
    }
}
