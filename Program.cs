using Mission3Assign;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create a list of objects (food items) that consists of name, cat, quantity, expiration
        bool exit = true;
        List<FoodItem> list = new List<FoodItem>();
        while (exit)
        {            
            Console.WriteLine("\nWhat would you like to do?\n");
            Console.WriteLine("1. Add food items");
            Console.WriteLine("2. Delete food items");
            Console.WriteLine("3. Print list of food items:");
            Console.WriteLine("4. Exit the program\n");
            Console.WriteLine("Please enter your option:");

            int choice = int.Parse(Console.ReadLine());

            // Add food item
            if (choice == 1)
            {
                Console.WriteLine("What's the name of the food item?");
                string name = Console.ReadLine();
                Console.WriteLine("What's the category of the food item?");
                string category = Console.ReadLine();
                Console.WriteLine("How many do you have?");
                string quantity = Console.ReadLine();

                int quant;
                while (true)
                {
                    try
                    {
                        quant = int.Parse(quantity);
                        if (quant < 0)
                        {
                            Console.WriteLine("Please enter a positive number");
                            quantity = Console.ReadLine();
                            continue;
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e.Message}");
                        Console.WriteLine("How many do you have? Please insert a positive integer");
                        quantity = Console.ReadLine();
                    }
                }

                Console.WriteLine("When does the food item expire?");
                string expdate = Console.ReadLine();

                FoodItem foodItem = new FoodItem(name, category, quantity, expdate);
                list.Add(foodItem);

            }

            // Delete food item from list
            else if (choice == 2)
            {
                
                if (list.Count == 0)
                {
                    Console.WriteLine("There are no food items in your list!");
                }

                else
                {
                    Console.WriteLine("Which food item would you like to delete?");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine((i + 1).ToString() + ": " + list[i].Name);
                    }
                    int num = int.Parse(Console.ReadLine());
                    list.Remove(list[num - 1]);
                }
            }

            // Print list of items
            else if (choice == 3)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ": " + list[i].Name + " belong to the category " + list[i].Cat + ". You have " + list[i].Quantity + " that expire on " + list[i].ExpDate);
                }
            }

            // Exit program
            else if (choice == 4)
            {
                exit = false;
            }

            else
            {
                Console.WriteLine("Invalid choice! Please try again.");
            }
        }
    }
}