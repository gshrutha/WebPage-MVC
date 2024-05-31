using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebPage.Context;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class CustomerKeysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerKeysController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            var Keys = GetCustomerKeys(10146);
            return View(Keys);
        }

        public List<CustomerKeys> GetCustomerKeys(int id)
        {
            List<CustomerKeys> Keys = new List<CustomerKeys>();

            try
            {
                Keys = _context.GetCustomerKeysAll.FromSqlInterpolated($"EXECUTE GetCusotmerKeysWithId {id}").ToList();
                return Keys;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
