using BurgerLord.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerLord.Controllers
{
    public class MenuController : Controller
    {
        private readonly IFoodRepository foodRepository;
        private readonly IFoodTypeRepository foodTypeRepository;

        public MenuController(IFoodRepository foodRepository, IFoodTypeRepository foodTypeRepository)
        {
            this.foodRepository = foodRepository;
            this.foodTypeRepository = foodTypeRepository;
        }
        public IActionResult Index()
        {
            string text = "";

            foreach (var item in foodRepository.GetAll())
            {
                text += item.Name + "\n";
            }
            

            return Content(text);
        }

        
    }
}
