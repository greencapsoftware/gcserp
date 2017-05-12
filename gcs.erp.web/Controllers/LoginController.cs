using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gcs.erp.web.VM.Login;
using gcs.erp.web.Model.Containers;

namespace gcs.erp.web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public IActionResult Index(LoginVM vm)
        {
            if (ModelState.IsValid)
            {
                SessaoContainer.Login();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}