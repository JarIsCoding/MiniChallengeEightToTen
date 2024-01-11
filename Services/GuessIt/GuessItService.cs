namespace MiniChallengeEightToTen.Services.GuessIt
{
    public class GuessItService : IGuessItService
    {
        public Random random = new();
        public string GuessItEasy(string num)
        {
            int easyWin = random.Next(1, 11);

            if (int.TryParse(num, out int number))
            {
                if (number >= 1 && number <= 10)
                {
                    if (number > easyWin)
                    {
                        return $"You guessed {num}, and the winning number is lower!";
                    }
                    else if (number < easyWin)
                    {
                        return $"You guessed {num}, and the winning number is higher!";
                    }
                    else
                    {
                        return $"You guessed {num}, and it was the correct answer! ({easyWin})";
                    }
                }
                else
                {
                    return "Please input a number that is 1-10";
                }
            }
            else
            {
                return "Invalid Input, please input a number that is 1-10";
            }

        }
        public string GuessItMedium(string num)
        {
            int medWin = random.Next(1, 51);

            if (int.TryParse(num, out int number))
            {
                if (number >= 1 && number <= 50)
                {
                    if (number > medWin)
                    {
                        return $"You guessed {num}, and the winning number is lower!";
                    }
                    else if (number < medWin)
                    {
                        return $"You guessed {num}, and the winning number is higher!";
                    }
                    else
                    {
                        return $"You guessed {num}, and it was the correct answer! ({medWin})";
                    }
                }
                else
                {
                    return "Please input a number that is 1-50";
                }
            }
            else
            {
                return "Invalid Input, please input a number that is 1-50";
            }
        }

        public string GuessItHard(string num)
        {
            int hardWin = random.Next(1, 101);

            if (int.TryParse(num, out int number))
            {
                if (number >= 1 && number <= 100)
                {
                    if (number > hardWin)
                    {
                        return $"You guessed {num}, and the winning number is lower!";
                    }
                    else if (number < hardWin)
                    {
                        return $"You guessed {num}, and the winning number is higher!";
                    }
                    else
                    {
                        return $"You guessed {num}, and it was the correct answer! ({hardWin})";
                    }
                }
                else
                {
                    return "Please input a number that is 1-100";
                }
            }
            else
            {
                return "Invalid Input, please input a number that is 1-100";
            }
        }
    }
}