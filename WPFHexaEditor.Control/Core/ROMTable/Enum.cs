using System;

//Enumeration du Namespace VRS.Library.DTE
namespace WPFHexaEditor.Core.ROMTable
{
    /// <summary>
    /// Type de DTE qui sera utilis� dans les classe de DTE
    /// </summary>
    public enum DTEType
    {
        Invalid = -1,
        ASCII = 0,
        Japonais,
        DualTitleEncoding,
        MultipleTitleEncoding,
        EndLine,
        EndBlock

    }
}