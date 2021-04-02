using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Temp.Models;

namespace Temp.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewData["Title"] = "Book Home Page";
            var books=new List<BookItem>();
            for(int i=0;i<100;i++)
            {
                books.Add(new BookItem{ID="B"+i,Name="Name"+i,Autor="Autor"+i});
            }
            return View(books);
        }

       [Authorize]
       public IActionResult Add()
        {
            ViewData["Title"] = "Book Home Add Page";
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
        public IActionResult RsvpForm(BookItem item)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Message="Successful";
                return View();
            }
            else
            {
                ViewBag.Message="";
                foreach (var modelState in ViewData.ModelState.Values) {
                foreach (var error in modelState.Errors) {
                    ViewBag.Message+=error.ErrorMessage+"\r\n";
                }}

                return View();
            }
        }
    }
}
