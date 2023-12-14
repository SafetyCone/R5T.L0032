using System;

using R5T.T0131;


namespace R5T.L0032.F003
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        public char AuthorsListSeparator_Character => Instances.Characters.Semicolon;
        public string DescriptionForProject_Default => "--- ADD DESCRIPTION ---";
    }
}
