using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace code_first.Models
{
    public class Khoa
    {
        [Key]
        public int IdKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
}