using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>();

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from the ListDataAccess database.");
            return Products;
        }



        public void SaveData()
        {
            Console.WriteLine("Saving data to the ListDataAccess database.");
        }
    }
}
