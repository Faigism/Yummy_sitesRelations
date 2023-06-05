using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Yummy_RelationsSite_HomeTask_.DAL;
using Yummy_RelationsSite_HomeTask_.Entities;
using Yummy_RelationsSite_HomeTask_.ViewModels;

namespace Yummy_RelationsSite_HomeTask_.Controllers
{
    public class HomeController:Controller
    {
        private readonly DB_Context _context;

        public HomeController(DB_Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Chef> chiefs = _context.Chefs.Include(p=>p.Profession).Include(x=>x.ChefSocialMedia).AsEnumerable();
            IEnumerable<Profession> professions = _context.Professions.AsEnumerable();
            IEnumerable<ChefSocialMedia> chefSocialMedias = _context.ChefSocialMedias.AsEnumerable();
            IEnumerable<Testimonial> testimonials = _context.Testimonials.Include(x=>x.Profession).AsEnumerable();
            ChefProfessionVM model = new()
            {
                Chefs= chiefs,
                Professions= professions,
                ChefSocialMedias= chefSocialMedias,
                Testimonials= testimonials
            };
            return View(model);
        }
    }
}
