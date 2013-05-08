using ErrorHandler.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandler.ExceptionHandling
{
	public class GlobalErrorHandler : HandleErrorAttribute
	{
		public override void OnException(ExceptionContext filterContext)
		{
			if (filterContext.Exception is BusinessException) {

				var controllerName = (string)filterContext.RouteData.Values["controller"];
				var actionName = (string)filterContext.RouteData.Values["action"];

				HandleErrorInfo model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);

				filterContext.Result = new ViewResult {
					ViewName = "~/Views/Shared/Error.cshtml",
					ViewData = new ViewDataDictionary<HandleErrorInfo>(model)
				};

				filterContext.ExceptionHandled = true;
			}

			//filterContext.HttpContext.IsCustomErrorEnabled
			base.OnException(filterContext);
		}
	}
}