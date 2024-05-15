using ExamTask.Business.Services.Abstracts;
using ExamTask.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExamTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;

        public HomeController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IActionResult Index()
        {
            var sliders = _sliderService.GetAllSliders();

            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders
            };

            return View(homeVM);
        }
    }
}
