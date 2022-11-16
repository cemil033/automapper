using Abp.Domain.Uow;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;
using WebApplication5.Models.ViewModels;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        public HomeController(IMapper mapper,ILogger<HomeController> logger)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(UserSignViewModel model)
        {
            var user=_mapper.Map<User>(model);
            var model1 = _mapper.Map<UserSignViewModel>(user);
            return View(model1);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}