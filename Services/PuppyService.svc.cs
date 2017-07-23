using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL.Model;
using DAL.Repository;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PuppyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PuppyService.svc or PuppyService.svc.cs at the Solution Explorer and start debugging.
    public class PuppyService : IPuppyService
    {
        private IPuppy puppyRepo = new PuppyImpl();

        public void addNewPuppy(Puppy newPuppyInfo)
        {
            throw new NotImplementedException();
        }

        public void deletePuppy(int puppyId)
        {
            throw new NotImplementedException();
        }

        public List<Puppy> getAllPuppies()
        {
            return puppyRepo.getAllPuppies();
        }

        public List<Puppy> getPuppyByGender(string gender)
        {
            throw new NotImplementedException();
        }

        public void updatePuppy(Puppy updatedPuppy)
        {
            throw new NotImplementedException();
        }
    }
}
