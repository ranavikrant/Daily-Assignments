using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Authentication_Authorization.Models
{
    public class User
    {   [Required]
        public string username { get; set; }
        [Required]
        
        public string password { get; set; }
        public List<User> l = new List<User>();

        
    }
}