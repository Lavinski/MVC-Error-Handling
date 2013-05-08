using ErrorHandler.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandler.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			throw new BusinessException("The application doesn't really do anything so you can't use it right now unless you are a developer!");
		}

	}
}
