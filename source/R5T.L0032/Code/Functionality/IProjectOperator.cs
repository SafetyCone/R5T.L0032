using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;
using R5T.T0179.Extensions;
using R5T.T0202;


namespace R5T.L0032
{
    [FunctionalityMarker]
    public partial interface IProjectOperator : IFunctionalityMarker
    {
        public string Get_WarningsConcatentation(IEnumerable<int> warnings)
        {
            var output = Instances.StringOperator.Join(
                Instances.Characters.Semicolon,
                warnings.Select(
                    warning => warning.ToString()
                )
            );

            return output;
        }

        public string Get_WarningsConcatentation(params int[] warnings)
        {
            var output = this.Get_WarningsConcatentation(warnings.AsEnumerable());
            return output;
        }

        public string Get_WarningsConcatentation(IEnumerable<IWarning> warnings)
        {
            var values = warnings.Get_Values();

            var output = this.Get_WarningsConcatentation(values);
            return output;
        }

        public string Get_WarningsConcatentation(params IWarning[] warnings)
        {
            var output = this.Get_WarningsConcatentation(warnings.AsEnumerable());
            return output;
        }
    }
}
