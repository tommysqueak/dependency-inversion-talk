using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conker.DI.Before.BeforeDI;
using Conker.DI.Common.Logging;

namespace Conker.DI.Mvc.Controllers
{
    public class HomeController : Controller
    {
    	public ActionResult Index()
        {
    		return new ContentResult
    		       	{
    		       		Content = "Hello World"
    		       	};
        }
    }
}
