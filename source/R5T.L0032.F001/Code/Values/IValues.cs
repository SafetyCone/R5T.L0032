using System;

using R5T.T0131;


namespace R5T.L0032.F001
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker,
        F003.IValues,
        Z001.IValues
    {

    }
}
