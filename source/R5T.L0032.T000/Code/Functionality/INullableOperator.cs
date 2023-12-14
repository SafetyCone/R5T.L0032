using System;

using R5T.T0132;


namespace R5T.L0032.T000
{
    [FunctionalityMarker]
    public partial interface INullableOperator : IFunctionalityMarker
    {
        public string To_String(Nullable nullable)
        {
            var output = nullable switch
            {
                Nullable.Annotations => Instances.Strings.Annotations,
                Nullable.Disabled => Instances.Strings.Disabled,
                Nullable.Enabled => Instances.Strings.Enabled,
                Nullable.Warnings => Instances.Strings.Warnings,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedSwitchValueException()
            };

            return output;
        }
    }
}
