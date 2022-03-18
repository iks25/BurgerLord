using System.Collections;
using System.Collections.Generic;

namespace BurgerLord.Models
{
    public interface IFoodTypeRepository
    {
        IEnumerable<FoodType> GetAll();
        FoodType GetById(int id);
        FoodType GetByName(string name);
      

    }
}
