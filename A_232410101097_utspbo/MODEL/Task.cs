using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101097_utspbo.MODEL
{
    internal class Task
    {
        [Key]
        public int id_tugas { get; set; }
        [Required]
        public string nama_tugas { get; set; }
        [Required]
        public string tanggal_tugas { get; set; }
        [Required]
        public string deadline { get; set; }
        [Required]
        public string deskripsi { get; set; }
        [Required]

    }
}