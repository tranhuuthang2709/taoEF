using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace code_first.Models
{
    public class SinhVien
    {
        [Key]
        public int IdSv { get; set; }
        public string TenSv { get; set; }
        public int Tuoi { get; set; }

        public int IdLop { get; set; }

        public virtual Lop Lop { get; set; } 
    }
}