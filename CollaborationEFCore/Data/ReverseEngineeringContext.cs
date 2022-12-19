using System;
using CollaborationEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CollaborationEFCore.Data
{
    public partial class PetFinderContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

