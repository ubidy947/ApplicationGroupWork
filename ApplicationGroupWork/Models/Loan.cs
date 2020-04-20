using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApplicationGroupWork.Models
{
    public class Loan
    {
        [Key]
        public int LoanID { get; set; }
        public int MemberID { get; set; }
        public int DvdDetailID { get; set; }
        [Required]
        public DateTime DateOut { get; set; }
        [Required]
        public DateTime DateIn { get; set; }
        [Required]
        public string FineAmount { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Members { get; set; }
        [ForeignKey("DvdDetailId")]
        public virtual DvdDetail DvdDetails { get; set; }
    }
}