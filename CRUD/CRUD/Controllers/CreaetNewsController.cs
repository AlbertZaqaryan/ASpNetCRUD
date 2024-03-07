using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
	public class CreateNewsController : Controller
	{
		private readonly ApplicationDbContext _context;

		public CreateNewsController(ApplicationDbContext context)
		{
			_context = context;
		}
		[HttpGet]
		public IActionResult Create() { 
			return View();
		}



		[HttpPost]
		public IActionResult Create(string Name, string Description)
		{
			News news = new News();

			news.Name = Name;		
			news.Description = Description;
			if (news != null) { 
				_context.NewsTable.Add(news);
				_context.SaveChanges();
			}
			return RedirectToAction("Create");

		}
	}
}
