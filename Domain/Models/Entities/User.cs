﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.models.entities
{
    [Index(nameof(Email), IsUnique = true)]
    public class User : IdentityUser<Guid>
    {
       /* [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid  Id{ get; set; }
        [Required]
        public string Email { get; set; } */
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; } = true;
        //TODO vérifier la logique > 
        public ICollection<Event> EventsCreated { get; set; } = new HashSet<Event>();
        public ICollection<Event> Events{ get; set; } = new HashSet<Event>();

        public int CampusId { get; set; }

    }
}
