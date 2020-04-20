using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationGroupWork.Models
{
    public class Studio
    {
        [Key] //primary key
        public int StudioID { get; set; }
        public string StudioName { get; set; }
        public string Address { get; set; }
    }
}