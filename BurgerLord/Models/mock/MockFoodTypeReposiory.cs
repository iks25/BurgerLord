using System.Collections.Generic;
using System.Linq;

namespace BurgerLord.Models.mock
{
    public class MockFoodTypeReposiory : IFoodTypeRepository
    {
        public IEnumerable<FoodType> _foodTypes { get; set; }

        public MockFoodTypeReposiory()
        {
            _foodTypes = new List<FoodType>()
            {
                new FoodType(){Id=1,Name="Burgers" },
                new FoodType(){Id=2,Name="Drinks"},
                new FoodType(){Id=3,Name="Hot Drinks"},
                new FoodType(){Id=4,Name="Wraps"},
            };
        }

        public IEnumerable<FoodType> GetAll()
        {
           return _foodTypes;
        }

        public FoodType GetById(int id)
        {
            return _foodTypes.FirstOrDefault(f => f.Id == id);
        }

        public FoodType GetByName(string name)
        {
            return _foodTypes.FirstOrDefault(f=>f.Name == name);
        }
    }
}
