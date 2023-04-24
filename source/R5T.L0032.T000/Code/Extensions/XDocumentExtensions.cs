using System;
using System.Xml.Linq;


namespace R5T.L0032.T000.Extensions
{
    public static class XDocumentExtensions
    {
        public static IProjectDocument ToProjectDocument(this XDocument value)
        {
            return Instances.XDocumentOperator.ToProjectDocument(value);
        }
    }
}
