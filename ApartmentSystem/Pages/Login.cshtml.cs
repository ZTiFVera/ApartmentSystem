using ApartmentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApartmentSystem.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User Users { get; set; } = new User();

        public IActionResult OnPost()
        {
            if (Users.Username == "Vera18" && Users.Password == "vera1234")
            {
                return RedirectToPage("/Index");
            }

            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return Page();
        }
        public void OnGet()
        {

        }
    }
}
