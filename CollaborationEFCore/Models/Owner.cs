using System;
using System.ComponentModel.DataAnnotations;

namespace CollaborationEFCore.Models
{
	public class Owner
	{
		[Key]
		public int Id { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; } = null!;

		[EmailAddress]
		public string Email { get; set; } = null!;
    }
}

