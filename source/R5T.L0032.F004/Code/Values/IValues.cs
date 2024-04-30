using System;

using R5T.T0131;


namespace R5T.L0032.F004
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        /// <summary>
        /// <para><value>Never</value></para>
        /// </summary>
        public string Never => "Never";
    }
}
