using ErrorHandler.ExceptionHandling;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandler
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new GlobalErrorHandler());
		}
	}
}