namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an number for furniture option");
            Console.WriteLine("1: Mattress, 2: Bedframe, 3: Lamp");
            string userInput = Console.ReadLine();

            IFurniture furniture = FurnitureFactory.GetFurniture(userInput);
            furniture.Order();

        }
    }
}
