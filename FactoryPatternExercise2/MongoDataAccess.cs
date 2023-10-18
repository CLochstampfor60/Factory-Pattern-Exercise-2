using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from the MongoDataAccess database.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to the MongoDataAccess database.");
        }
    }
}
