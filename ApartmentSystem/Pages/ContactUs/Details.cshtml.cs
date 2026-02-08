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
    public class DetailsModel : PageModel
    {
        private readonly ApartmentSystem.Data.ApartmentSystemContext _context;

        public DetailsModel(ApartmentSystem.Data.ApartmentSystemContext context)
        {
            _context = context;
        }

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
    }
}
