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

namespace ApartmentSystem.Pages.ContactInformation
{
    public class EditModel : PageModel
    {
        private readonly ApartmentSystem.Data.ApartmentSystemContext _context;

        public EditModel(ApartmentSystem.Data.ApartmentSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactInfo ContactInfo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactinfo =  await _context.ContactInfo.FirstOrDefaultAsync(m => m.Id == id);
            if (contactinfo == null)
            {
                return NotFound();
            }
            ContactInfo = contactinfo;
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

            _context.Attach(ContactInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactInfoExists(ContactInfo.Id))
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

        private bool ContactInfoExists(int id)
        {
            return _context.ContactInfo.Any(e => e.Id == id);
        }
    }
}
