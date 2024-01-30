using Microsoft.AspNetCore.Mvc;

using IM999MaxBonum.Models;
using IM999MaxBonum.Classes;

namespace IM999MaxBonum.Controllers
{
    public class PageController: BaseController
    {
        public IActionResult Detail(int id){
            var vp = clsPage.GetvPageById(id);

            ViewData["ShowSlider"] = true;
            ViewData["PageName"] = vp.PageName;
            
            ViewData["BreadCrumbLinks"] = null;

            return View(vp);
        }
    }
}

