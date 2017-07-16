using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ISEM_551.Models;
using DAL.Model;

namespace ISEM_551.Controllers
{
    public class AdoptionController : Controller
    {
        // GET: Adoption
        public ActionResult Index()
        {
            ViewBag.Message = "Puppies List";
            PuppyBLL tempBLL = new PuppyBLL();
            var puppies = tempBLL.getAllPuppies();
            List<PuppyVM> puppyvms = populateToVM(puppies);

            return View(puppyvms);
        }


        private List<PuppyVM> populateToVM(List<Puppy> puppies)
        {
            List<PuppyVM> result = new List<PuppyVM>();

            for(int i = 0; i <puppies.Count; i++)
            {
                var puppy = puppies[i];
                var puppyVM = new PuppyVM()
                {
                    Id = puppy.Id,
                    Name = puppy.Name,
                    Gender = puppy.Gender,
                    Breed = puppy.Breed,
                    Color = puppy.Color,
                    OwnerName = puppy.OwnerName,
                    Weight = puppy.Weight,
                    DOB = puppy.DOB,
                };
                result.Add(puppyVM);
            }
            return result;
        }


    }
}