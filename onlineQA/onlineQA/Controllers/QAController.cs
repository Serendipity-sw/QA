using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onlineQA.Controllers
{
    public class QAController : Controller
    {
        // GET: QA
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult userInfo()
        {
            return View();
        }
        public ActionResult updatePassWord()
        {
            return View();
        }
    }
}