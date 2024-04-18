using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using code_first.Models;
namespace code_first.Controllers
{
    public class HomeController : Controller
    {

        SchoolDBContext db = new SchoolDBContext();
        // GET: Home
        public ActionResult Index()
        {
            var sinhViensCNTT = db.Sv
                                  .Where(sv => sv.Lop.Khoa.TenKhoa == "CNTT" 
                                  && sv.Tuoi >= 18 && sv.Tuoi <= 20)
                                  .ToList();

            return View(sinhViensCNTT);
        }
    }
}