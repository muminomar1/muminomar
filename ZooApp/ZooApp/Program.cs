using ZooManagement;

class Program
{
    static void Main(string[] args)
    {
        IZooManager zooManager = new ZooManager(); // Dependency Inversion
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nZoo Management System");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. List Animals");
            Console.WriteLine("3. Update Animal");
            Console.WriteLine("4. Delete Animal");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter age: ");

                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.WriteLine("Invalid age. Try again.");
                        break;
                    }

                    Animal animal = new Animal(name, age);
                    zooManager.AddAnimal(animal);
                    break;

                case "2":
                    zooManager.ListAnimals();
                    break;

                case "3":
                    Console.Write("Enter the name of the animal to update: ");
                    string updateName = Console.ReadLine();
                    Console.Write("Enter new name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new age: ");

                    if (!int.TryParse(Console.ReadLine(), out int newAge))
                    {
                        Console.WriteLine("Invalid age. Try again.");
                        break;
                    }

                    zooManager.UpdateAnimal(updateName, newName, newAge);
                    break;

                case "4":
                    Console.Write("Enter the name of the animal to delete: ");
                    string deleteName = Console.ReadLine();
                    zooManager.DeleteAnimal(deleteName);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Exiting Zoo Management System. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}