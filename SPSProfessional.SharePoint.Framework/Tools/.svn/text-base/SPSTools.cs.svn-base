// File : SPSTools.cs
// Date : 29/07/2008
// User : csegura
// Logs

using System.Web;
using System.Web.UI;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;

namespace SPSProfessional.SharePoint.Framework.Tools
{
    public static class SPSTools
    {
        /// <summary>
        /// Determines whether [is I e55 plus] [the specified context].
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        /// 	<c>true</c> if [is I e55 plus] [the specified context]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsIE55Plus(HttpContext context)
        {
            if (context != null)
            {
                if (context.Request == null)
                {
                    return true;
                }
                HttpBrowserCapabilities browser = context.Request.Browser;
                if (browser == null)
                {
                    return true;
                }
                if (((browser.Type.IndexOf("IE") >= 0) && browser.Win32)
                    && ((browser.MajorVersion >= 6) 
                    || ((browser.MajorVersion >= 5) 
                    && (browser.MinorVersion >= 0.5))))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the current page URL.
        /// </summary>
        /// <returns>The page url without parameters</returns>        
        public static string GetCurrentPageBaseUrl(Page page)
        {
            string currentPageUrl = page.Request.Url.ToString();

            if (currentPageUrl.IndexOf('?') > 0)
            {
                currentPageUrl = currentPageUrl.Substring(0, currentPageUrl.IndexOf('?'));
            }

            return currentPageUrl;
        }

        /// <summary>
        /// Gets the current URL.
        /// </summary>
        /// <returns>The current full Url</returns>
        public static string GetCurrentUrl()
        {
            return
                    SPHttpUtility.UrlKeyValueEncode(
                            SPContext.Current.Web.Site.MakeFullUrl(SPUtility.OriginalServerRelativeRequestUrl));
        }
    }
}