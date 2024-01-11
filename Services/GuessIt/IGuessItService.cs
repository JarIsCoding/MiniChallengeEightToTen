namespace MiniChallengeEightToTen.Services.GuessIt
{
    public interface IGuessItService
    {
        string GuessItEasy(string num);

        string GuessItMedium(string num);

        string GuessItHard(string num);
    }
}