using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaperseedPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";
            List<SliderImage> SliderImages = new List<SliderImage>();
            SliderImages.Add(new SliderImage { Title = "Welcome to Paperseed!", SubTitle = "We build future web applications.", Url = "images/slider1.jpg" });
            SliderImages.Add(new SliderImage { Title = "Intuitive UI", SubTitle = "We make websites simpler with esthetic user interface.", Url = "images/slider2.jpg" });
            SliderImages.Add(new SliderImage { Title = "High quality code", SubTitle = "Robust is our keyword when it comes to coding.", Url = "images/slider3.jpg" });
            SliderImages.Add(new SliderImage { Title = "Extendable design", SubTitle = "We plan for your growth from our first draft.", Url = "images/slider4.jpg" });
            
            ViewBag.SliderUrls = SliderImages; 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Under construction";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Under construction";

            return View();
        }

        public class SliderImage
        {
            public int SliderImageId { get; set; }
            public string Url { get; set; }
            public string Title { get; set; }
            public string SubTitle { get; set; }
        }
    }
}
