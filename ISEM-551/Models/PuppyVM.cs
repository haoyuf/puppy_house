using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ISEM_551.Models
{
    public class PuppyVM
    {
        [DisplayName ("Id")]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName ("Gender")]
        public string Gender { get; set; }

        [DisplayName("Breed")]
        public string Breed { get; set; }

        [DisplayName("Color")]
        public string Color { get; set; }

        [DisplayName("Weight")]
        public float Weight { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("OwnerName")]
        public string OwnerName { get; set; }

        [DisplayName("DOB")]
        public DateTime DOB { get; set; }
    }
}