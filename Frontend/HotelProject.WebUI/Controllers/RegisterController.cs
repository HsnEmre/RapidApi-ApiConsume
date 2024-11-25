using HotelProject.EntityLayer;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{



    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (ModelState.IsValid)
            {
                var appUser = new AppUser()
                {
                    Name = createNewUserDto.Name,
                    Email = createNewUserDto.Email,
                    Surname = createNewUserDto.Surname,
                    UserName = createNewUserDto.Username
                };

                var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }


            return View();
        }
    }
}
