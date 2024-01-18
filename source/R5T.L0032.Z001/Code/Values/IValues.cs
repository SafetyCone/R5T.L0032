using System;

using R5T.T0131;


namespace R5T.L0032.Z001
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        /// <summary>
        /// <para><value>Default</value></para>
        /// </summary>
        public string Default => "Default";
    }
}
