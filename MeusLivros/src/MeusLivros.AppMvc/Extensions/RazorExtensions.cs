using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeusLivros.AppMvc.Extensions
{
    public static class RazorExtensions
    {
        public static bool AllowDisplay(this WebViewPage page, string claimName, string claimValue)
            => CustomAuthorization.ValidateUserClaims(claimName, claimValue);

        public static MvcHtmlString AllowDisplay(this MvcHtmlString value, string claimName, string claimValue) =>
            CustomAuthorization.ValidateUserClaims(claimName, claimValue) ?
            value :
            MvcHtmlString.Empty;

        public static string ActionWithPermission(this UrlHelper urlHelper, string actionName, string controllerName, object routeValues, string claimName, string claimValue)
            => CustomAuthorization.ValidateUserClaims(claimName, claimValue) ? 
            urlHelper.Action(actionName, controllerName, routeValues) : 
            "";

        public static string FormatDocument(this WebViewPage page, int personType, string document) 
            => personType == 1
                ? Convert.ToUInt64(document).ToString(@"000\.000\.000\-00")
                : Convert.ToUInt64(document).ToString(@"00\.000\.000\/0000\-00");

        public static bool DisplayInURL(this WebViewPage value, Guid Id)
        {
            var urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            var urlTarget = urlHelper.Action("Edit", "Providers", new { id = Id });
            var urlTarget2 = urlHelper.Action("GetAddress", "Providers", new { id = Id });

            var urlEmUso = HttpContext.Current.Request.Path;

            return urlTarget == urlEmUso || urlTarget2 == urlEmUso;
        }
    }
}