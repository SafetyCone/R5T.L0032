using System;


namespace R5T.L0032.F003
{
    public class AuthorsOperator : IAuthorsOperator
    {
        #region Infrastructure

        public static IAuthorsOperator Instance { get; } = new AuthorsOperator();


        private AuthorsOperator()
        {
        }

        #endregion
    }
}
