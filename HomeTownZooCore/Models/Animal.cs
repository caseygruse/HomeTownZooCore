using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTownZooCore.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public string Breed { get; set; }

        public DateTime? AdoptionDate { get; set; }

    }
}
