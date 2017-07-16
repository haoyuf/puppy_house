using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Model
{
    public class Puppy
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }
        
        [DisplayName("Breed")]
        public string Breed { get; set; }

        [DisplayName("Color")]
        public string Color { get; set; }

        [DisplayName("Weight")]
        public float Weight { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("ID")]
        public string Id { get; set; }

        [DisplayName("Owner Name")]
        public string OwnerName { get; set; }

        [DisplayName("DOB")]
        public string DOB { get; set; }
    }
}
