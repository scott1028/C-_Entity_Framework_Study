using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Castle.ActiveRecord;
using Castle.Core.Configuration;
using Castle.ActiveRecord.Framework.Config;
using Castle.ActiveRecord.Framework;

namespace testwB.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			// For ActiveRecord Start
			User1 obj = User1.Find (1);
			// For ActiveRecord End

			ViewData ["Runtime"] = obj.User_id;
			return View ();
		}
	}
}

