using System;

using R5T.T0131;


namespace R5T.L0032.Z002
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        /// <summary>
        /// <para><value>1573;1587;1591</value></para>
        /// </summary>
        public string NoWarn_Default_WarningsList => "1573;1587;1591";
    }
}
