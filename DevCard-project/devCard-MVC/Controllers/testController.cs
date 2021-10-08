//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.IO;
//using System.Net.Mime;

//namespace devCard_MVC.Controllers
//{
//    public class testController : Controller
//    {
//       // public IActionResult Index()
//       //{
//       // //    var filebyte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
//       // //    var filename = "test.txt";
//       // //    return File(filebyte, MediaTypeNames.Text.Plain, filename);
//       // }

//        public JavaScriptResult java()
//        {
//            return new JavaScriptResult("alert('salam salam hamegi salam')");
//        }
        
//    }
//   public class JavaScriptResult:ContentResult
//    {
//        public JavaScriptResult(string data)
//        {
//            Content = data;
//            ContentType = "application/javascript";
//        }
//    }
//}
