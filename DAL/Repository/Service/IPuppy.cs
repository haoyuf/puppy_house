using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.Repository
{
    public interface IPuppy
    {
        //Create
        void addNewPuppy(Puppy newPuppyInfo);

        //Read
        List<Puppy> getPuppyByGender(string gender);
        List<Puppy> getAllPuppies();


        //Update
        void updatePuppy(Puppy updatedPuppy);


        //Delete
        void deletePuppy(int puppyId);
    }
}
