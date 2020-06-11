using banhoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace banhoa.Controllers
{
    public class HomeController : Controller
    {

        ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Hoa
        public ActionResult Index()
        {
            List<Hoa> listHoa = dbContext.hoas.Take(9).ToList();//database
            return View(listHoa);

        }
        public ActionResult XemChiTiet(int id)
        {
            Hoa hoa = dbContext.hoas.Find(id);//database
            return View("XemChiTiet", hoa);
        }
        public ActionResult HoDiepTrang()
        {
            List<Hoa> listHoa = dbContext.hoas.Take(9).ToList();//database
            return View(listHoa);
        }
        public ActionResult HoDiepTim()
        {
            List<Hoa> listHoa = dbContext.hoas.Take(9).ToList();//database
            return View(listHoa);

           
        }
       
        public ActionResult HoDiepVang()
        {
            List<Hoa> listHoa = dbContext.hoas.Take(9).ToList();//database
            return View(listHoa);
           
        }
        public ActionResult HoDiepXanhDuong()
        {
            List<Hoa> listHoa = dbContext.hoas.Take(9).ToList();//database
            return View(listHoa);
        }
      


    }
}