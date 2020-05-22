using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlueOrange.Compiler;
using BlueOrange.Compiler.Interfaces;
using BlueOrange.Compiler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlueOrange.Models;

namespace BlueOrange.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CompilerAlgorithm compiler;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            compiler = new CompilerAlgorithm();
        }

        public IActionResult Index()
        {
            return View();
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

        [HttpPost]
        public JsonResult Compile(CodeRequestDTO codeRequest)
        {
            try
            {
                IOrangeLanguage srcLanguage =
            compiler.GetConcreteLanguageImplementation(codeRequest.DstLanguage);

                string compiledCode = compiler.Compile(srcLanguage);

                CodeAnswerDTO translatedCode = new CodeAnswerDTO(compiledCode);

                return Json(translatedCode);
            }
            catch (Exception ex)
            {
                // Log something somewhere ...maybe later
                return Json(new CodeAnswerDTO("Error", ex.Message));
            }
        }
    }
}
