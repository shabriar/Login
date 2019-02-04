using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginPortal.Models
{
    public class Bikes
    {
        [Key]
        public int Id { get; set; }
        public string BikeModel { get; set; }
        public int BikeCc { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}