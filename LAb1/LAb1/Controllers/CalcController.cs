using Microsoft.AspNetCore.Mvc;

namespace LAb1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
        public IActionResult PassUsingModel(Services.CalcService calcService)
        {
            int a = calcService.GetInt();
            int b = calcService.GetInt();

            Dictionary<string, string> viewModel = new Dictionary<string, string>();

            viewModel["a"] = a.ToString();
            viewModel["b"] = b.ToString();
            viewModel["Add"] = calcService.Add(a, b).ToString();
            viewModel["Sub"] = calcService.Sub(a, b).ToString();
            viewModel["Mult"] = calcService.Mult(a, b).ToString();
            viewModel["Div"] = calcService.Div(a, b).ToString();

            return View(viewModel);
        }
        public IActionResult PassUsingViewBag(Services.CalcService calcService)
        {
            int a = calcService.GetInt();
            int b = calcService.GetInt();

            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.Add = calcService.Add(a, b);
            ViewBag.Sub = calcService.Sub(a, b);
            ViewBag.Mult = calcService.Mult(a, b);
            ViewBag.Div = calcService.Div(a, b);

            return View();
        }
        public IActionResult PassUsingViewData(Services.CalcService calcService)
        {
            int a = calcService.GetInt();
            int b = calcService.GetInt();

            ViewData["a"] = a.ToString();
            ViewData["b"] = b.ToString();
            ViewData["Add"] = calcService.Add(a, b);
            ViewData["Sub"] = calcService.Sub(a, b);
            ViewData["Mult"] = calcService.Mult(a, b);
            ViewData["Div"] = calcService.Div(a, b);

            return View();
        }
    }
}
