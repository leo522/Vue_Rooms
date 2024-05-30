using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoomStyle.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Rooms
        public ActionResult RoomPrice()
        {
            return View();
        }

        public ActionResult RoomType()
        {
            return View();
        }

        public ActionResult iOS_CalanderType() 
        {
            return View();
        }
    }
}