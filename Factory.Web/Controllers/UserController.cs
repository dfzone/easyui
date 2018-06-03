using Factory.Web.Models;
using Factory.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Factory.Web.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            UserVM vm = new UserVM();
            var rv=vm.Search();
            return Json(rv,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(User user)
        {
            UserVM vm = new UserVM();
            var count = vm.Add(user);
            if (count == 1)
            {
                var rv = new { success = true };
                return Json(rv, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var rv = new { success = false };
                return Json(rv, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Update(User user)
        {
            UserVM vm = new UserVM();
            var count = vm.Update(user);
            if (count == 1)
            {
                var rv = new { success = true };
                return Json(rv, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var rv = new { success = false };
                return Json(rv, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete(int id)
        {
            UserVM vm = new UserVM();
            var rv = vm.Search();
            return Json(rv, JsonRequestBehavior.AllowGet);
        }

    }
}
