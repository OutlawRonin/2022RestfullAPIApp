using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2022RestfullAPIApp.Models
{
    public class Applicant
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name can only be 100 characters long")]
        public string Name { get; set; }

        public string JobId { get; set; }

        //[ForeignKey("JobId")]
        //public virtual Job Job { get; set; }
    }
}
