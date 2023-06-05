namespace Yummy_RelationsSite_HomeTask_.Entities
{
    public class Chef
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; } = null!;
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
        public ChefSocialMedia ChefSocialMedia { get; set; }
        public Testimonial Testimonial { get; set; }
    }
}
