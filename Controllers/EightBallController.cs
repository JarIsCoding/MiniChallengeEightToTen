using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Services.EightBall;


namespace MiniChallengeEightToTen.Controllers;
[ApiController]
[Route("EightBall")]
public class EightBallController : ControllerBase
{
    private readonly IEightBallService _eightBallService;

    public EightBallController(IEightBallService eightBallService)
    {
        _eightBallService = eightBallService;
    }

    [HttpGet]
    [Route("AskAQuestion/{yourQuestion}")]
    public string AskMe(string yourQuestion)
    {
        return _eightBallService.AskMe(yourQuestion);
    }
}