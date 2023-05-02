using Microsoft.AspNetCore.Mvc;
using Sierov_D_KN_2_3.Models;
using System.Diagnostics;

namespace Sierov_D_KN_2_3.Controllers
{
    public class VerificationController : Controller
    {
        private readonly ILogger<VerificationController> _logger;
        public VerificationController(ILogger<VerificationController> logger)
        {
            _logger = logger;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public List<Account> users = new List<Account>
        {
            new Account { name = "User1", email = "user1@mail.com" , password = "0001"},
            new Account { name = "User2", email = "user2@mail.com" , password = "0002"},
            new Account { name = "User3", email = "user3@mail.com" , password = "0003"},
            new Account { name = "User4", email = "user4@mail.com" , password = "0004"}
        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(Account user)
        {
            if (ModelState.IsValid)
            {
                foreach (Account acc in users)
                {
                    if (user.name == acc.name && user.email == acc.email && user.password == acc.password)
                    {
                        return View();
                    }
                }
                return View("CheckFail");
            }

            return View("Index");
        }


    }
}