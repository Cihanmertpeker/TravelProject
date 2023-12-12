using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class AddressBlog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyAddress { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}