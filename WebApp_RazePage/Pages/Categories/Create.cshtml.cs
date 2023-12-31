using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApp_RazePage.Data;
using WebApp_RazePage.Model;

namespace WebApp_RazePage.Pages.Categories;
[BindProperties]


public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _db;
	
		public Category Category { get; set; }
		public CreateModel(ApplicationDbContext db)
    {
        _db= db;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost()
    {
        if (Category.Name==Category.DisplayOrder.ToString())
        {
            ModelState.AddModelError(string.Empty,"The DisplayOrder cannot exactly match the Name");
        }
        if (ModelState.IsValid)
        {
			await _db.Categories.AddAsync(Category);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
        return Page();
    }
}
