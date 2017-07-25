using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using ISEM_551.Models;
using ISEM_551.ServiceReference;

namespace ISEM_551.Controllers
{
    public class AdoptionController : Controller
    {
        // GET: Adoption
        public ActionResult Index()
        {
            ViewBag.Message = "Puppies List";

            PuppyServiceClient puppyService = new PuppyServiceClient();
            var puppies = puppyService.getAllPuppies().ToList();
            List<PuppyVM> puppyvms = populateToVM(puppies);

            return View(puppyvms);
        }


        private List<PuppyVM> populateToVM(List<PuppyDTO> puppies)
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

            ViewBag.welcomeMessage = "Welcome to the Puppy House Adoption";
            return result;
        }


    }
}