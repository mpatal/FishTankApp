using System;
using FishTankApp.Services;
using Microsoft.AspNet.Mvc;

namespace FishTankApp.Controllers
{
    public class HomeController: Controller
    {
        private IViewModelService _viewModelService;

        public HomeController(IViewModelService viewModelService)
        {
            _viewModelService = viewModelService;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Fish tank dashboard" ;
            return  View(_viewModelService.GetDashboardViewModel());
        }
    }

}
