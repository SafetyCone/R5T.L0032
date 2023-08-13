using System;

using R5T.T0142;


namespace R5T.L0032.T000
{
    [DataTypeMarker]
    public interface IWithProjectElement : 
        IHasProjectElement
    {
        new IProjectElement ProjectElement { set; }
    }
}
