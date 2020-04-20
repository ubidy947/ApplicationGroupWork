using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApplicationGroupWork.Models
{
    public class Member
    {
        //primary key
        [Key]
        public int MemberID { get; set; }
        public int MemberCategoryID { get; set; }
        [Required] //attribute(mandatory data)
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Email { get; set; }
        //foreignkey from membercategory model class
        [ForeignKey("MemberCategoryID")]
        public virtual MemberCategory MemberCategorys { get; set; }
    }
}