using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Models
{
    public class Users
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool Status { get; set; }

       // public string Gender { get; set; }
    }
}
