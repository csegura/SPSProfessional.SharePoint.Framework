using System;
using System.IO;
using System.Web.UI;
using SPSProfessional.SharePoint.Framework.Controls;

namespace SPSProfessional.SharePoint.Framework.Controls
{
    /// <summary>
    /// Control to render a Chart
    /// </summary>
    public class SPSXsltChartControl : SPSXsltControl, ISPSXsltChartControl
    {
        private string _graphWidth = "200";
        private string _graphHeight = "150";
        private string _graphType = "Column2D";

        #region Properties ISPSXsltChartControl

        /// <summary>
        /// Gets or sets the width of the graph.
        /// </summary>
        /// <value>The width of the graph.</value>
        public string GraphWidth
        {
            get { return _graphWidth; }
            set { _graphWidth = value; }
        }

        /// <summary>
        /// Gets or sets the height of the graph.
        /// </summary>
        /// <value>The height of the graph.</value>
        public string GraphHeight
        {
            get { return _graphHeight; }
            set { _graphHeight = value; }
        }

        /// <summary>
        /// Gets or sets the type of the graph.
        /// </summary>
        /// <value>The type of the graph.</value>
        public string GraphType
        {
            get { return _graphType; }
            set { _graphType = value; }
        }

        #endregion

        #region Control

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Load"/> event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.EventArgs"/> object that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            const string scriptName = "SPSProfessional_FusionCharts";
            ClientScriptManager clientScript = Page.ClientScript;
            if (!clientScript.IsClientScriptBlockRegistered(scriptName))
            {
                clientScript.RegisterClientScriptInclude(
                        scriptName,
                        "/_layouts/FusionCharts/FusionCharts.js");
            }

            base.OnLoad(e);
        }

        /// <summary>
        /// Internals the render.
        /// Make the Xslt transformation
        /// </summary>
        /// <param name="writer">The writer.</param>
        public override void RenderControlInternal(HtmlTextWriter writer)
        {
            StringWriter stringWriter = Transform();
            string xml = stringWriter.ToString();

            xml = xml.Replace("'", "");
            xml = xml.Replace('"', '\'');

            DebugRender(writer, xml);

            writer.Write("<div id=\"{0}\"></div>", UniqueID + "chart");
            writer.Write("\n<script language=\"JavaScript\">\n");
            writer.Write("var {1}Chart=new FusionCharts(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"0\",\"1\");\n",
                         "/_layouts/FusionCharts/FCF_" + GraphType + ".swf",
                         UniqueID,
                         GraphWidth,
                         GraphHeight);

            writer.Write("{1}Chart.setDataXML(\"{0}\");\n", xml, UniqueID);
            writer.Write("{1}Chart.render(\"{0}\");\n", UniqueID + "chart", UniqueID);
            writer.Write("</script>\n");
            writer.Write(stringWriter);
        }

        #endregion
    }
}