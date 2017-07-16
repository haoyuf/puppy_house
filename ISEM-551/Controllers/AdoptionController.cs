using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace ISEM_551.Controllers
{
    public class AdoptionController : Controller
    {
        // GET: Adoption
        public ActionResult Index()
        {
            ViewBag.Message = "Puppies List";

            var puppies = Puppies.getPuppies();

            return View(puppies);
        }
    }
}