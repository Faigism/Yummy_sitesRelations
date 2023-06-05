using Yummy_RelationsSite_HomeTask_.Entities;

namespace Yummy_RelationsSite_HomeTask_.ViewModels
{
    public class ChefProfessionVM
    {
        public IEnumerable<Chef> Chefs { get; set; }
        public IEnumerable<Profession> Professions { get; set; }
        public IEnumerable<ChefSocialMedia> ChefSocialMedias { get; set; }
        public IEnumerable<Testimonial>  Testimonials{ get; set; }
    }
}
