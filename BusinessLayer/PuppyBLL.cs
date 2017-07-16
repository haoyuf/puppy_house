using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL.Repository;

namespace BLL
{
    public class PuppyBLL
    {
        private IPuppy _IPuppyRepo;
        public IPuppy IPuppyRepo
        {
            get
            {
                return _IPuppyRepo != null ? _IPuppyRepo : new PuppyImpl();
            }
                
        }


        public List<Puppy> getAllPuppies()
        {
            List<Puppy> puppies = IPuppyRepo.getAllPuppies();        
            return puppies;
        }
    }
}
