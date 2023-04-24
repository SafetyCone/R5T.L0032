using System;

using R5T.T0132;

using R5T.L0032.T000;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IIncludedElementOperator : IFunctionalityMarker
    {
        public string Get_IncludeValue(IIncludedElement includedElement)
        {
            var output = Instances.XmlOperator.Get_AttributeValue(
                includedElement.Value,
                Instances.ProjectElementNames.Include);

            return output;
        }
    }
}
