using System;

using R5T.L0030.T000;
using R5T.L0030.T000.Extensions;
using R5T.T0131;


namespace R5T.L0032.Z000
{
    [ValuesMarker]
    public partial interface ICustomProjectElementNames : IValuesMarker
    {
        /// <summary>
        /// <para>PrivateGitHubRepository</para>
        /// Property used to indicate that a project file is in local Git repository clone of a private GitHub repository.
        /// </summary>
        public IElementName PrivateGitHubRepository => "PrivateGitHubRepository".ToElementName();
    }
}
