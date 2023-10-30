using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApp_RazePage.Data;
using WebApp_RazePage.Model;

namespace WebApp_RazePage.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Category> Categories { get; set; }
        public void OnGet()
        {
            Categories = _db.Categories;
        }
    }
}
