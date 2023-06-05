using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yummy_RelationsSite_HomeTask_.DAL;
using Yummy_RelationsSite_HomeTask_.Entities;
using Yummy_RelationsSite_HomeTask_.ViewModels;

namespace Yummy_RelationsSite_HomeTask_.Controllers
{
    public class ChefsController:Controller
    {
        private readonly DB_Context _context;
        public ChefsController(DB_Context context)
        {
            _context = context;
        }
        public IActionResult Details(int id)
        {
            if (id<=0)
            {
                return BadRequest();
            }
            Chef? chef = _context.Chefs.FirstOrDefault(c => c.Id == id);

            if (chef == null)
            {
                return NotFound();
            }

            return View(chef);
        }
    }
}
