using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2.DataAccess
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Brand { get; set; }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        [Required]
        [Range(1900, 2030)]
        public int Year { get; set; }

        public Owner Owners { get; set; }

    }
}
