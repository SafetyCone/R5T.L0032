using System;

using R5T.T0142;


namespace R5T.L0032.T000
{
    /// <summary>
    /// The raw COM reference data for the Visual Studio project file.
    /// </summary>
    [DataTypeMarker]
    public class COMReference
    {
        public string Name { get; set; }
        public string WrapperTool { get; set; }
        public int Version_Major { get; set; }
        public int Version_Minor { get; set; }
        public Guid Guid { get; set; }
        /// <summary>
        /// Locale identifier.
        /// </summary>
        public int Lcid { get; set; }
        public bool Isolated { get; set; }
        public bool EmbedInteropTypes { get; set; }
    }
}
