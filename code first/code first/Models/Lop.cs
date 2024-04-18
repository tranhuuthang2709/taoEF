using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace code_first.Models
{
    public class Lop
    {
        [Key]
        public int IdLop { get; set; }
        public string TenLop { get; set; }
        public virtual Khoa Khoa { get; set; }
    }

}