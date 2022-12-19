using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CollaborationEFCore.Models
{
    public partial class Pet
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string PetName { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string PetType { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string OwnerName { get; set; } = null!;
    }
}
