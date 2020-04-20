using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApplicationGroupWork.Models
{
    public class Producer
    {
        [Key] //primary key
        public int ProducerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public int StudioID { get; set; }
        //foreign key intialized
        [ForeignKey("StudioID")]
        public virtual Studio Studios { get; set; } 
    }
}