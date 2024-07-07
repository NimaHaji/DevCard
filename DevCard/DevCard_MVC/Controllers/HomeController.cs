using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			
			return View();
		}
		[HttpGet]
		public IActionResult Contact()
		{
			return View();
		}
		//[HttpPost]
		//      public JsonResult Contact(IFormCollection form)
		//      {
		//	var name = form["name"];
		//	var email = form["email"];
		//	var service = form["service"];
		//	var message = form["message"];
		//          return Json(Ok());
		//      }
		[HttpPost]
		public JsonResult Contact(Contact form)
		{
			Console.WriteLine(form.ToString());
			return Json(Ok());
		}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
