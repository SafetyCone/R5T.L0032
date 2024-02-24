using System;


namespace R5T.L0032.F002
{
    public static class Instances
    {
        public static Z002.ICompanyNames CompanyNames => Z002.CompanyNames.Instance;
        public static L0071.ICopyrightOperator CopyrightOperator => L0071.CopyrightOperator.Instance;
        public static Z002.IGroupLabels GroupLabels => Z002.GroupLabels.Instance;
        public static IPropertyGroupXElementOperator PropertyGroupXElementOperator => F002.PropertyGroupXElementOperator.Instance;
        public static Z002.IValues Values => Z002.Values.Instance;
    }
}