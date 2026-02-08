using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApartmentSystem.Data;
using ApartmentSystem.Models;

namespace ApartmentSystem.Pages.UserInfo
{
    public class DetailsModel : PageModel
    {
        private readonly ApartmentSystem.Data.ApartmentSystemContext _context;

        public DetailsModel(ApartmentSystem.Data.ApartmentSystemContext context)
        {
            _context = context;
        }

        public PersonalInformation PersonalInformation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalinformation = await _context.PersonalInformation.FirstOrDefaultAsync(m => m.Id == id);
            if (personalinformation == null)
            {
                return NotFound();
            }
            else
            {
                PersonalInformation = personalinformation;
            }
            return Page();
        }
    }
}
