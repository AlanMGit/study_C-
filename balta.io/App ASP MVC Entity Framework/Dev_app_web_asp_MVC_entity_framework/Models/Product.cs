using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dev_app_web_asp_MVC_entity_framework.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int Title { get; set; }
    }
}