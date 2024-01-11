namespace MiniChallengeEightToTen.Services.EightBall
{
    public class EightBallService : IEightBallService
    {
        public string AskMe(string input)
        {
            string[] answers = { "My reply is no", "Try again later", "Cannot predict now", "Signs Point to No", "Definitely", "Most Likely", "My sources are saying no", "You may rely on it" };
            Random random = new();
            int randomIndex = random.Next(0, answers.Length);
            return $"The eight ball says... {answers[randomIndex]}.";
        }
    }
}