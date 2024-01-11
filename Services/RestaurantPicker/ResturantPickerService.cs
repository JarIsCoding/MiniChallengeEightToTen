namespace MiniChallengeEightToTen.Services.RestaurantPicker
{
    public class ResturantPickerService : IRestaurantPickerService
    {
        public string[] asian = { "Panda Express", "Saigon Bay", "Pho island", "Jimmies place", "Lao Der", "Thai Cuisine", "Tasty Thai", "Bangkok", "Fuji Sushi", "Ramen 101" };
        public string[] mexican = { "Hugo's", "South Philly Barbacoa", "Guelaguetza", "Flores", "Elote Cafe", "Cosme", "Barrio Cafe", "Oyamel Cocina Mexicana", "Taco Bell", "Topolobampo" };
        public string[] american = { "Chili's", "KFC", "In N' Out", "Buffalo Wild Wings", "Fire Wings", "Burger King", "McDonalds", "Wendy's", "Red Lobster", "Denny's" };

        public Random random = new Random();

        public string RestaurantPicker(string input)
        {
            int randomIndex = random.Next(0, 10);
            string userInput = input.ToLower();
            if (userInput == "asian" || userInput == "mexican" || userInput == "american")
            {
                if (userInput == "asian")
                {
                    return $"You should eat at {asian[randomIndex]}!";
                }
                else if (userInput == "mexican")
                {
                    return $"You should eat at {mexican[randomIndex]}!";
                }
                else
                {
                    return $"You should eat at {american[randomIndex]}!";
                }
            }
            else
            {
                return "Please choose between Asian / Mexican / American.";
            }


        }
    }
}