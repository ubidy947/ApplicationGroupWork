using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationGroupWork.Models
{
    public class MemberCategory
    {
        [Key]
        public int MemberCategoryID { get; set; }
        [Required]
        public string MemberName { get; set; }
        [Required]
        public string TotalLoans { get; set; }
        public string Description { get; set; }
        [Required]
        public string FineAmountPerDay { get; set; }
        [Required]
        public string ReturningDays { get; set; }
    }
}