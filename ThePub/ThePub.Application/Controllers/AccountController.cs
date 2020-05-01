using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ThePub.Application.Models.AccountViewModels;
using ThePub.Data.DTO;
using ThePub.Services.Contracts;

namespace ThePub.Application.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return base.View();
        }

    }
}