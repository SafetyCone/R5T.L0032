using System;

using R5T.T0131;


namespace R5T.L0032.Z000
{
    /// <summary>
    /// Element names for use in Visual Studio project XML files.
    /// Contains both custom and common names.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectElementNames : IValuesMarker,
        N001.IProjectElementNames,
        ICustomProjectElementNames
    {
    }
}
