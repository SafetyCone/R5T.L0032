using System;

using R5T.T0221;

using R5T.L0032.T000;


namespace R5T.L0032.Extensions
{
    public static class ILabeledExtensions
    {
        public static string Get_Label(this ILabeled labeled)
        {
            return Instances.LabeledOperator.Get_Label(labeled);
        }

        public static WasFound<string> Has_Label(this ILabeled labeled)
        {
            return Instances.LabeledOperator.Has_Label(labeled);
        }
    }
}
