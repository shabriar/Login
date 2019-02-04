using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoginPortal.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }
        public string UserPassword { get; set; }
        public bool IsDeleted { get; set; }

        public int? BikeId { get; set; }
        [ForeignKey("BikeId")]
        public  virtual Bikes Bikes { get; set; }

       
    }
}