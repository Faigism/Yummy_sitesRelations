namespace Yummy_RelationsSite_HomeTask_.Entities
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Image { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string About { get; set; } = null!;
        public int ChefId { get; set; }
        public Chef Chef { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
