namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database do you want to use: a List, SQL, or Mongo?");
            var userResponse = Console.ReadLine();
    
            IDataAccess newData = DataAccessFactory.GetDataAccess(userResponse);

            List <Product> products = newData.LoadData();
            newData.SaveData();

            Console.WriteLine();
            Console.WriteLine("-----------------------");


        }
    }
}
