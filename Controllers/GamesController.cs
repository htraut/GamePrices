using GamePrices.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GamePrices.Controllers
{
    public class GamesController : Controller
    {
        private GameDBContext gameDb = new GameDBContext();

        // GET: Games
        public async Task<ActionResult> Index()
        {
            return View(await gameDb.Games.ToListAsync());
        }

        // GET: Games/Search
        public async Task<ActionResult> Search(string searchString)
        {
            var game = from i in gameDb.Games select i;

            if (!String.IsNullOrEmpty(searchString))
            {
                game = game.Where(i => i.Title.Contains(searchString));
            }

            return View(await game.ToListAsync());
        }
    }
}