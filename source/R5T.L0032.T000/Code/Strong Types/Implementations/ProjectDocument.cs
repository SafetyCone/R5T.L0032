using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.L0032.T000
{
    [StrongTypeImplementationMarker]
    public class ProjectDocument : TypedBase<XDocument>, IStrongTypeImplementationMarker,
        IProjectDocument
    {
        public ProjectDocument(XDocument value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(XDocument a, XDocument b)
        {
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(XDocument a, XDocument b)
        {
            throw new NotImplementedException();
        }
    }
}
