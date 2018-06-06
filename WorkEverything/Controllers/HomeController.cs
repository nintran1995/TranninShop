using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranninShop.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[ChildActionOnly]//Chi de nhung
		public ActionResult Header()
		{
			return PartialView();
		}

		[ChildActionOnly]//Chi de nhung
		public ActionResult Bander()
		{
			return PartialView();
		}

		[ChildActionOnly]//Chi de nhung
		public ActionResult Footer()
		{
			return PartialView();
		}
	}
}