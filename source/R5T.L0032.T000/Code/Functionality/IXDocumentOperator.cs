using System;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.L0032.T000
{
    [FunctionalityMarker]
    public partial interface IXDocumentOperator : IFunctionalityMarker
    {
        public IProjectDocument ToProjectDocument(XDocument value)
        {
            var output = new ProjectDocument(value);
            return output;
        }
    }
}
