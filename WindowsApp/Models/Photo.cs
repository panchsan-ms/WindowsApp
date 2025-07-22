using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsApp.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}