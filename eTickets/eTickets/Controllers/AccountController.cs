using eTickets.Data;
using eTickets.Data.ViewModels;
using eTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _singInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> singInManager, AppDbContext context)
        {
            _userManager = userManager;
            _singInManager = singInManager;
            _context = context;
        }

        public IActionResult Login() => View(new LoginVM());
    }
}
