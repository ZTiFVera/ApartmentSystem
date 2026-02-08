using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ApartmentSystem.Data;
using ApartmentSystem.Models;

namespace ApartmentSystem.Pages.ContactUs
{
    public class CreateModel : PageModel
    {
        private readonly ApartmentSystem.Data.ApartmentSystemContext _context;

        public CreateModel(ApartmentSystem.Data.ApartmentSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactUsInformation ContactUsInformation { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ContactUsInformation.Add(ContactUsInformation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
