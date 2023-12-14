using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.L0032.F003
{
    [FunctionalityMarker]
    public partial interface IAuthorsOperator : IFunctionalityMarker
    {
        public string Combine(IEnumerable<string> authors)
        {
            var output = Instances.StringOperator.Join(
                Instances.Values.AuthorsListSeparator_Character,
                authors);

            return output;
        }

        public string Combine(params string[] authors)
        {
            return this.Combine(authors.AsEnumerable());
        }
    }
}
