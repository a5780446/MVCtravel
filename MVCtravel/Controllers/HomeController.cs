using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCtravel.Models;

namespace MVCtravel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<nm> places = new List<nm>();
            places.Add(new nm { id = "A01", name = "六福村", addr = "新竹縣關西鎮60 號" });
            places.Add(new nm { id = "A02", name = "海天一線", addr = "300新竹市北區" });
            places.Add(new nm { id = "A03", name = "新竹城隍廟", addr = "300新竹市北區中山路75號" });
            places.Add(new nm { id = "A04", name = "新竹高鐵站", addr = "302新竹縣竹北市高鐵七路6號" });
            places.Add(new nm { id = "A05", name = "佛陀世界", addr = "306新竹縣關西鎮號" });
            places.Add(new nm { id = "A06", name = "南寮風景區", addr = "300新竹市北區新港三路1之9號" });
            places.Add(new nm { id = "A07", name = "內灣老街", addr = "312新竹縣橫山鄉光復路" });
            places.Add(new nm { id = "A08", name = "司馬庫斯", addr = "313新竹縣尖石鄉玉峰村14鄰司馬庫斯2號" });
            return View(places);

        }
    }
}