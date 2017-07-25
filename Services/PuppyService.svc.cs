using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO;
using BLL;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PuppyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PuppyService.svc or PuppyService.svc.cs at the Solution Explorer and start debugging.
    public class PuppyService : IPuppyService
    {
        
        public void addNewPuppy(PuppyDTO newPuppyInfo)
        {
            throw new NotImplementedException();
        }

        public void deletePuppy(int puppyId)
        {
            throw new NotImplementedException();
        }

        public List<PuppyDTO> getAllPuppies()
        {
            PuppyBLL bll = new PuppyBLL();
            return bll.getAllPuppies();
        }

        public List<PuppyDTO> getPuppyByGender(string gender)
        {
            throw new NotImplementedException();
        }


        public void updatePuppy(PuppyDTO updatedPuppy)
        {
            throw new NotImplementedException();
        }
    }
}
