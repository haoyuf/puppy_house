using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessLayer
{
    public class Puppies
    {
        public static List<Puppy> getPuppies()
        {
            Puppy puppy1 = new Puppy();
            puppy1.Name = "Buddy";
            puppy1.Gender = "Male";
            puppy1.Breed = "Golden Retreiver";

            Puppy puppy2 = new Puppy();
            puppy2.Name = "Lola";
            puppy2.Gender = "Female";
            puppy2.Breed = "Labrador Retreiver";

            List<Puppy> puppies = new List<Puppy>();
            puppies.Add(puppy1);
            puppies.Add(puppy2);
        
            return puppies;
        }
    }
}
