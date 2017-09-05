using GlobalizationExample.LocalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Xml.Linq;

namespace GlobalizationExample.Models
{
    public class User
    {
       
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        [Required]

        public string Name { get; set; }

        
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        [Required]
        public string Password { get; set; }
    }
}