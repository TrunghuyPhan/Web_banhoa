using banhoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace banhoa.Controllers
{
    
    public class HoaController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Hoa
        public ActionResult Index()
        {
            List<Hoa> listHoa = dbContext.hoas.Take(20).ToList();//database
            return View(listHoa);
            
        }
        public ActionResult XemChiTiet(int id)
        {
            Hoa hoa = dbContext.hoas.Find(id);//database
            return View("XemChiTiet", hoa);
        }
    
    }
}