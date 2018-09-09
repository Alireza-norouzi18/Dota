using Dota.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Dota.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Heroes()
        {
            return View();
        }

        public ActionResult Abaddon()
        {
            return View();
        }

        public ActionResult HeroName(string name)
        {
            ViewBag.name = name;
            return View();
        }

        public ActionResult HeroDetails(int index)
        {
            Hero[] heroes = new Hero[2];
            

            // Abaddon
            heroes[0] = new Hero();
            heroes[0].Name = "Abaddon";
            heroes[0].Lane = "Off";
            heroes[0].Description = "Invoker is a strength hero.";
            heroes[0].MainImage = "/Content/img/$.png";
            heroes[0].Spells = new string[4];
            heroes[0].Spells[0] = "/Content/img/Mist_Coil_icon.png";
            heroes[0].Spells[1] = "/Content/img/Aphotic_Shield_icon.png";
            heroes[0].Spells[2] = "/Content/img/Curse_of_Avernus_icon.png";
            heroes[0].Spells[3] = "/Content/img/Borrowed_Time_icon.png";

            // Invoker
            heroes[1] = new Hero();
            heroes[1].Name = "Invoker";
            heroes[1].Lane = "Mid";
            heroes[1].Description = "Invoker is an intelligent hero.";
            heroes[1].MainImage = "/Content/img/ezgif-2-623c6fcbcd.gif";
            heroes[1].Spells = new string[6];
            heroes[1].Spells[0] = "/Content/img/Quas_icon.png";
            heroes[1].Spells[1] = "/Content/img/Wex_icon.png";
            heroes[1].Spells[2] = "/Content/img/Exort_icon.png";
            heroes[1].Spells[3] = "/Content/img/Invoke_icon.png";


            Hero hero = heroes[index];

            return View(hero);
        }

    }
}