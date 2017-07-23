using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using BusinessLayer.ServiceReference;

namespace BLL
{
    public class PuppyBLL
    {
        public List<Puppy> getAllPuppies()
        {
            PuppyServiceClient puppyService = new PuppyServiceClient();
            return puppyService.getAllPuppies().ToList();
        }
    }
}
