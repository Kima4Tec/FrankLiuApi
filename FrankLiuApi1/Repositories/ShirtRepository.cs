using FrankLiuApi1.Models;

namespace FrankLiuApi1.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
            {
            new Shirt {ShirtId = 1, Brand="Cool", Color="Blue", Gender = "Men", Price=120, Size=9},
            new Shirt {ShirtId = 2, Brand="Coolio", Color="White", Gender = "Men", Price=180, Size=10},
            new Shirt {ShirtId = 3, Brand="SpringFlower", Color="Red", Gender = "Women", Price=320, Size=7},
            new Shirt {ShirtId = 4, Brand="Heart", Color="Red", Gender = "Women", Price=250, Size=8}
            };
        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static List<Shirt> GetShirts()
        {
            return shirts;
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
