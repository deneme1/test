using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4ViewMvc.Controllers
{
    public class DummyController : Controller
    {
        //
        // GET: /Dummy/

        public ActionResult Index(){
            return View();
        }

        public ActionResult Create() {
            return View();
        }

        public ActionResult Custom() {
            return View();
        }

    }
}
