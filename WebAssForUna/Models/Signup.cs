using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebAssForUna.Models
{
    public class Signup
    {
        [Required]
        public string Firstname { get; set; } = "";
        [Required]
        public string Surname { get; set; } = "";

        [Required]
        public string Gender { get; set; } = "";
        public string Male { get; set; } = "";
        public string Female { get; set; } = "";
        public string Other { get; set; } = "";

        [Required]
        [Range(110, 200)]
        public int Height { get; set; }

        public int Birthday { get; set; }

        [Required]
        [StringLength(9)]
        public string Ppsn { get; set; } = "";

        public string Status { get; set; } = "";
        public string Single { get; set; } = "";
        public string Taken { get; set; } = "";
        public string Complicated { get; set; } = "";

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = "";
    }
}
