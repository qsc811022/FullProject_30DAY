﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApp_RazePage.Data;
using WebApp_RazePage.Model;

namespace WebApp_RazePage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<Category> Categories { get; set; }
        private readonly ILogger<IndexModel> _logger;



        public IndexModel(ApplicationDbContext db)
        {
            _db= db;
        }

        public void OnGet()
        {
            Categories = _db.Categories;
        }
    }
}