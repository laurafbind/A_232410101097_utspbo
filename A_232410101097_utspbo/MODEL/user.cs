using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101097_utspbo.MODEL
{
    internal class user
    {
        [Key]
        public int person_id { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
    }
}
