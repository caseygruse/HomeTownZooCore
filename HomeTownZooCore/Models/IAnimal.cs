using System;

namespace HomeTownZooCore.Models
{
    public interface IAnimal
    {
        DateTime? AdoptionDate { get; set; }
        int AnimalId { get; set; }
        string Breed { get; set; }
        string Name { get; set; }
    }
}