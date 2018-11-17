// File : SPSDebug.cs
// Date : 24/06/2008
// User : csegura
// Logs

using System;
using System.Diagnostics;

namespace SPSProfessional.SharePoint.Framework.Tools
{
    internal static class SPSDebug
    {
        [Conditional("DEBUG")]
        internal static void DumpException(string name, Exception ex)
        {
            Debug.WriteLine("PANIC:" + ex.TargetSite);
            Debug.WriteLine(string.Format("{0}", name));
            Debug.WriteLine(ex);
        }

        [Conditional("DEBUG")]
        internal static void DumpException(Exception ex)
        {
            Debug.WriteLine("PANIC:"+ex.TargetSite);
            Debug.WriteLine(ex);
        }
    }
}
