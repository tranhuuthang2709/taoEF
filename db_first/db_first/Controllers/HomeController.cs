using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using db_first.Models;

namespace db_first.Controllers
{
    public class HomeController : Controller
        
    {
        db_fisrtEntities db = new db_fisrtEntities();
        public ActionResult Index()
        {

            var sinhViensCNTT = db.Sv
        .Where(sv => sv.Lop.Khoa.TenKhoa == "Khoa CNTT"
         && sv.Tuoi >= 18 && sv.Tuoi <= 20)
         .ToList();

            return View(sinhViensCNTT);
        }

        
        }
}


