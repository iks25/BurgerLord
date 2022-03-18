using System.Collections.Generic;

namespace BurgerLord.Models
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetAll();
        Food GetById(int id);
        Food GetByName(string name);
    }
}
