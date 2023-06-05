using Microsoft.EntityFrameworkCore;
using Yummy_RelationsSite_HomeTask_.Entities;

namespace Yummy_RelationsSite_HomeTask_.DAL
{
    public class DB_Context:DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {

        }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ChefSocialMedia> ChefSocialMedias { get; set; }

    }
}
