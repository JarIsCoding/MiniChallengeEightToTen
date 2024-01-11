using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Services.RestaurantPicker;

namespace MiniChallengeEightToTen.Controllers
{
    [ApiController]
    [Route("RestaurantPicker")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly IRestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }

        [HttpGet]
        [Route("AsianAmericanMexican/{category}")]
        public string RestaurantPicker(string category){
            return _restaurantPickerService.RestaurantPicker(category);
        }
    }
}