using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class HomController : Controller
    {
       private readonly WebApplication1Context _db;
        public HomController(WebApplication1Context db)
        {
            _db = db;
        }
        public IActionResult Index(int pagId=1)
        {
            int skip = (pagId - 1)*3;
            int count = _db.Person.Count();
            ViewBag.pagId=pagId;
            ViewBag.pagcount=count/3;
            var list=_db.Person.OrderBy(p=> p.PersonId).Skip(skip).Take(3).ToList();
            return View(list);
        }
    }
}
