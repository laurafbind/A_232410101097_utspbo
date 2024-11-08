using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101097_utspbo.MODEL
{
    public class admin
    { 
       [Key]
       public int id_admin { get; set; }
       [Required]
       public string username { get; set; }
       [Required]
       public string pass { get; set; }
       [Required]
    }
}
