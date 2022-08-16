using Microsoft.AspNetCore.Mvc;
using pendu_poo_tu;
using PenduWeb.Data;

namespace PenduWeb.Controllers
{
    public class PartieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PartieController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var mot = MotAuHasard();
            return View();
        }

        private pendu_poo_tu.Mot MotAuHasard()
        {
            int nb_mots = this._context.Mots.Count();

            Random rnd = new Random();
            var indexMot = rnd.Next(nb_mots);
            var motData = this._context.Mots.Skip(indexMot).First();
            return new pendu_poo_tu.Mot(motData.Contenu);
        }
    }
}
