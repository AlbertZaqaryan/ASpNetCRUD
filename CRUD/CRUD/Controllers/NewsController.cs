using CRUD.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class NewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.NewsTable.ToList());
        }

        public IActionResult Delete(int GetId)
        {
            var OneNews = _context.NewsTable.Find(GetId);
            _context.NewsTable.Remove(OneNews);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
