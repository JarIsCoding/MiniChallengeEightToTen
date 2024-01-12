using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Services.GuessIt;


namespace MiniChallengeEightToTen.Controllers
{
    [ApiController]
    [Route("GuessIt")]
    public class GuessItController : ControllerBase
    {
        private readonly IGuessItService _guessItService;

        public GuessItController(IGuessItService guessItService)
        {
            _guessItService = guessItService;
        }

        [HttpGet]
        [Route("Easy1-10/{number}")]
        public string GuessItEasy(string number)
        {
            return _guessItService.GuessItEasy(number);
        }

        [HttpGet]
        [Route("Medium1-50/{number}")]
        public string GuessItMedium(string number)
        {
            return _guessItService.GuessItMedium(number);
        }

        [HttpGet]
        [Route("Hard1-100/{number}")]
        public string GuessItHard(string number)
        {
            return _guessItService.GuessItHard(number);
        }

    }
}