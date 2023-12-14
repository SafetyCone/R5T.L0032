using System;


namespace R5T.L0032.F003
{
    public static class Instances
    {
        public static IBooleanOperator BooleanOperator => F003.BooleanOperator.Instance;
        public static L0066.ICharacters Characters => L0066.Characters.Instance;
        public static IGuidOperator GuidOperator => F003.GuidOperator.Instance;
        public static IIntegerOperator IntegerOperator => F003.IntegerOperator.Instance;
        public static L0066.IPathOperator PathOperator => L0066.PathOperator.Instance;
        public static L0066.IStringOperator StringOperator => L0066.StringOperator.Instance;
        public static IValues Values => F003.Values.Instance;
        public static IVersionOperator VersionOperator => F003.VersionOperator.Instance;
    }
}