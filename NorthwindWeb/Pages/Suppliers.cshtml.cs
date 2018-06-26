using System;
using System.Collections.Generic;
using System.Linq;       
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindContextLib;
using NorthwindEntitiesLib;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {
        private Northwind db;
        public SuppliersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }
        public IEnumerable<string> Suppliers { get; set; }

        [BindProperty]
        public Supplier Supplier { get; set; }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            return Page();
        }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind-Suppliers";
            //Suppliers = new[] { "alpha co", "beta limited", "gamma corp" };
            Suppliers = db.Suppliers.Select(sup => sup.CompanyName).ToArray();
            var dbProducts = db.Products.Select(pro => pro.ProductName).ToArray();
        }
    }
}