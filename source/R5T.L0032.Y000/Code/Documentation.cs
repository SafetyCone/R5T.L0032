using System;


namespace R5T.L0032.Y000
{
	/// <summary>
	/// Documention for Visual Studio project file XML elements.
	/// </summary>
	public static partial class Documentation
	{
        /// <summary>
        /// A semicolon-separated list of package author names, matching profile names on nuget.org.
        /// These are displayed in the NuGet Gallery on nuget.org and are used to cross-reference packages by the same authors.
		/// <para>See "Authors" in: <inheritdoc cref="Links.MSBuildPackTarget" path="/summary"/></para>
        /// </summary>
        public static readonly object ForAuthorsElement;

		/// <summary>
		/// Property group and item group elements have an optional label attribute according to the MSBuild file schema.
		/// (<inheritdoc cref="Links.MSBuildSchemaFilePath" path="/summary"/>)
		/// </summary>
		public static readonly object ForGroupLabelAttribute;
	}
}
