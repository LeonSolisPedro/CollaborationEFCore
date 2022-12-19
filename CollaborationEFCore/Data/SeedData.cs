using System;
using CollaborationEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CollaborationEFCore.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PetFinderContext(serviceProvider.GetRequiredService<DbContextOptions<PetFinderContext>>()))
            {
                if (context.Pets.Any())
                    return;

                context.Pets.AddRange(
                    new Pet
                    {
                        Id = 1,
                        PetName = "Pancho",
                        PetType = "Perrito",
                        OwnerName = "Pedro León"
                    },

                    new Pet
                    {
                        Id = 1,
                        PetName = "Negro",
                        PetType = "Perrito",
                        OwnerName = "Pedro León"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

