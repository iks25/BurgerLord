using System.Collections.Generic;
using System.Linq;

namespace BurgerLord.Models.mock
{
    public class MockFoodRepository : IFoodRepository
    {

        IEnumerable<Food> Foods { get; set; }

        public MockFoodRepository()
        {
            Foods = new List<Food>()
            {
                new Food(){Id = 1, Name ="Burger Lord",}
            };

        }
        public IEnumerable<Food> GetAll()
        {
            return Foods;

        }

        public Food GetById(int id)
        {
            return Foods.FirstOrDefault(food => food.Id == id);
        }

        public Food GetByName(string name)
        {
           return Foods.FirstOrDefault(f=>f.Name == name);
        }
    }
}
