using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string Mail { get; set; }
        public string MemberComment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

    }
}