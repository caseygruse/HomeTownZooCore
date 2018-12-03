using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTownZooCore.Models
{
    /// <summary>
    /// used for Animal database Code
    /// </summary>
    public static class AnimalRepository
    {
        public static async Task<IEnumerable<Animal>> GetAnimals(ZooContext db)
        {
            return await db.Animal.ToListAsync();
            //NO!! New is glue, this tightly couples 
            //classes together, and is not ideal
            //ZooContext db = new ZooContext();
        }
    }
}
