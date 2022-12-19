using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CollaborationEFCore.Models;

namespace CollaborationEFCore.Data
{
    public partial class PetFinderContext : DbContext
    {

        public PetFinderContext(DbContextOptions<PetFinderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pet> Pets { get; set; } = null!;

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

        }
    }
}
