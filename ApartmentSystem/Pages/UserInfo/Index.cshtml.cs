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
    public class IndexModel : PageModel
    {
        private readonly ApartmentSystem.Data.ApartmentSystemContext _context;

        public IndexModel(ApartmentSystem.Data.ApartmentSystemContext context)
        {
            _context = context;
        }

        public IList<PersonalInformation> PersonalInformation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            PersonalInformation = await _context.PersonalInformation.ToListAsync();
        }
    }
}
