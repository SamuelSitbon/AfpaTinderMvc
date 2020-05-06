﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.Models
{
    [Table("Personne")]
    public class Personne : DbContext
    {
        [Key]
        [Column("idPersonne")]
        public int IdPersonne { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Nom { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Prenom { get; set; }
        
        [StringLength(100)]
        [Required]
        public string Email { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Login { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Password { get; set; }
        
        [StringLength(10)]
        public string Telephone { get; set; }
        
        [Required]
        public bool Status { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}