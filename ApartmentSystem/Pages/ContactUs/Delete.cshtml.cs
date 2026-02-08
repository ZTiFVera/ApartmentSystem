using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApartmentSystem.Data;
using ApartmentSystem.Models;

namespace ApartmentSystem.Pages.ContactUs
{
    public class DeleteModel : PageModel
    {
        private readonly ApartmentSystem.Data.ApartmentSystemContext _context;

        public DeleteModel(ApartmentSystem.Data.ApartmentSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactUsInformation ContactUsInformation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactusinformation = await _context.ContactUsInformation.FirstOrDefaultAsync(m => m.Id == id);

            if (contactusinformation == null)
            {
                return NotFound();
            }
            else
            {
                ContactUsInformation = contactusinformation;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactusinformation = await _context.ContactUsInformation.FindAsync(id);
            if (contactusinformation != null)
            {
                ContactUsInformation = contactusinformation;
                _context.ContactUsInformation.Remove(ContactUsInformation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
