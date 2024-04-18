using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace code_first.Models
{
    public class SchoolDBContext :DbContext
    {

        public SchoolDBContext() : base ("MyConnectionString"){}

        public DbSet<Lop> lops { get; set; }
        public DbSet<Khoa> khoas { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }

    }
}