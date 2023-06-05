namespace Yummy_RelationsSite_HomeTask_.Entities
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Testimonial> Testimonial { get; set; }
        public ICollection<Chef> Chefs { get; set; }
    }
}
