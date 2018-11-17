// File : SPSAboutEditor.cs
// Date : 30/01/2008
// User : csegura
// Logs

using System.Diagnostics;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;

namespace SPSProfessional.SharePoint.Framework.Tools
{
    internal class SPSAboutEditor : EditorPart
    {
        public SPSAboutEditor()
        {
            ID = "AboutEditor";
            Title = "About SPSProfessional";
            ChromeState = PartChromeState.Minimized;
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            WebPart webpart = WebPartToEdit;
            Debug.WriteLine(webpart.GetType());
            Assembly current = Assembly.GetAssembly(webpart.GetType());
            Debug.WriteLine(current);
            Assembly framework = Assembly.GetExecutingAssembly();
            Debug.WriteLine(framework);
            writer.WriteLine("<br><center><font color='blue'>");
            writer.WriteLine(current.GetName().Name.Replace(".", "<br>"));
            writer.WriteLine("</font><br><br>");
            writer.WriteLine("Version " + current.GetName().Version);
            writer.WriteLine("<br>");
            writer.WriteLine("*Framework " + framework.GetName().Version);
            writer.WriteLine("<br>");
            writer.WriteLine("Copyright (c) 2008<br>");
            writer.AddAttribute(HtmlTextWriterAttribute.Href, "http://www.spsprofessional.com");
            writer.AddAttribute(HtmlTextWriterAttribute.Target, "_blank");
            writer.RenderBeginTag(HtmlTextWriterTag.A);
            writer.Write("<br><b>SPSProfessional<br>Professional SharePoint Components</b>");
            writer.RenderEndTag();
            writer.Write("<br><br>");
        }

        public override bool ApplyChanges()
        {
            return true;
        }

        public override void SyncChanges()
        {
        }
    }
}