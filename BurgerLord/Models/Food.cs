namespace BurgerLord.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public int MyProperty { get; set; }

        public string ImgageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }
        public string AllergyInformation { get; set; }


        public int FoodTypeId { get; set; }
    }

}
