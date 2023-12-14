using System;
using System.Xml.Linq;

using R5T.T0142;


namespace R5T.L0032.T000.N001
{
    [DataTypeMarker]
    public interface IWithProjectElement : 
        IHasProjectElement
    {
        new XElement ProjectElement { set; }
    }
}
