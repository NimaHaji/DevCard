using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using System.Net.Mime;

namespace DevCard_MVC.Controllers
{
    public class testController : Controller
    {
        //public IActionResult Index()
        //{
        //    // return File("~/test.txt","text/html");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string filename = "testFile.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, filename);
        //}
        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        name = "nima",
        //        family = "Haji",
        //        Company = "Unix",
        //        Age = "19"
        //    });
        //}
        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("alert('salam')");
        //}
        //public RedirectResult index()
        //{
        //    return Redirect("https://www.github.com");
        //}
        //public RedirectToActionResult index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}
    }
    public class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string data)
        {
            Content=data;
            ContentType = "application/Javascript";
        }
    }
}
