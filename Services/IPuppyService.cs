using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL.Model;

namespace Services
{
    [ServiceContract]
    public interface IPuppyService
    {

        [OperationContract]
        void addNewPuppy(Puppy newPuppyInfo);

        [OperationContract]
        List<Puppy> getPuppyByGender(string gender);

        [OperationContract]
        List<Puppy> getAllPuppies();

        [OperationContract]
        void updatePuppy(Puppy updatedPuppy);

        [OperationContract]
        void deletePuppy(int puppyId);
    }
    
}
