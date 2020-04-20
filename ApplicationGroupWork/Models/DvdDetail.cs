using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApplicationGroupWork.Models
{
    public class DvdDetail
    {
        [Key]
        public int DvdDetailID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Length { get; set; }
        [Required]
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public virtual Producer Producers { get; set; }


    }
}