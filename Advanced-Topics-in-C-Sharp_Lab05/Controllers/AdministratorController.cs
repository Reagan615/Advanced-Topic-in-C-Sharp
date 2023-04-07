using Advanced_Topics_in_C_Sharp_Lab05.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Advanced_Topics_in_C_Sharp_Lab05.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        private readonly BankingDbContext _context;
        public AdministratorController(BankingDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Users.Include(a => a.BankAccounts).ToList());
        }
        public IActionResult CreateManager()
        {
            return View();
        }
    }
}
