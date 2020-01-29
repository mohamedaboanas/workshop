using System;
using System.Linq;

namespace Vidzy
{
    internal class Program
    {
        private static void Main()
        {
            var dbContext = new VidzyDbContext();
            dbContext.AddVideo("Volcano", DateTime.Now, "Family", (byte)Classification.Gold);

            var getVedio = dbContext.Videos.ToList();

            foreach (var vedio in getVedio)
            {
                Console.WriteLine(vedio.Name);
            }
        }
    }
}