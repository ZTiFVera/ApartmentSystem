using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApartmentSystem.Data;
using ApartmentSystem.Models;

namespace ApartmentSystem.Pages.ContactUs
{
    public class EditModel : PageModel
    {
        private readonly ApartmentSystem.Data.ApartmentSystemContext _context;

        public EditModel(ApartmentSystem.Data.ApartmentSystemContext context)
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

            var contactusinformation =  await _context.ContactUsInformation.FirstOrDefaultAsync(m => m.Id == id);
            if (contactusinformation == null)
            {
                return NotFound();
            }
            ContactUsInformation = contactusinformation;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ContactUsInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactUsInformationExists(ContactUsInformation.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ContactUsInformationExists(int id)
        {
            return _context.ContactUsInformation.Any(e => e.Id == id);
        }
    }
}
