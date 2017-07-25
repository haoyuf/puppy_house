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
    [ServiceContract]
    public interface IPuppyService
    {

        [OperationContract]
        void addNewPuppy(PuppyDTO newPuppyInfo);

        [OperationContract]
        List<PuppyDTO> getPuppyByGender(string gender);

        [OperationContract]
        List<PuppyDTO> getAllPuppies();

        [OperationContract]
        void updatePuppy(PuppyDTO updatedPuppy);

        [OperationContract]
        void deletePuppy(int puppyId);
    }
    
}
