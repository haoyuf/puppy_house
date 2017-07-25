using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PuppyDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Breed { get; set; }

        public string Color { get; set; }

        public float Weight { get; set; }

        public string Address { get; set; }

        public string OwnerName { get; set; }

        public DateTime DOB { get; set; }

        public int DaysLived { get; set; }
    }
}
