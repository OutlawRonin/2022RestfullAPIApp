using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;






namespace _2022RestfullAPIApp.Models
{
    public class Job
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name can only be 100 characters long")]
        public string Name { get; set; }
    }
}
