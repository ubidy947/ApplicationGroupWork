using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationGroupWork.Models
{
    public class CastMember
    {
        [Key]
        public int CastID { get; set; }
        public int CastDetailID { get; set; }
        public int DvdDetailID { get; set; }

        //foreign keys
        public virtual CastDetail CastDetails { get; set; }
        public virtual DvdDetail DvdDetails { get; set; }
    }
}