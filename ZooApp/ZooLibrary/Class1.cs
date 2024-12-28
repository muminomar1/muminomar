using System;
using System.Collections.Generic;

namespace ZooManagement
{
    // Concrete class for animals
    public class Animal
    {
        // Encapsulation: Protect fields with properties
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Update(string newName, int newAge)
        {
            Name = newName;
            Age = newAge;
        }
    }

    // Dependency Inversion: Interface for Zoo Operations
    public interface IZooManager
    {
        void AddAnimal(Animal animal);
        void ListAnimals();
        void UpdateAnimal(string name, string newName, int newAge);
        void DeleteAnimal(string name);
    }

    // Dependency Inversion: Concrete implementation of IZooManager
    public class ZooManager : IZooManager
    {
        private readonly List<Animal> _animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            Console.WriteLine($"Added {animal.Name} to the zoo.");
        }

        public void ListAnimals()
        {
            if (_animals.Count == 0)
            {
                Console.WriteLine("The zoo has no animals yet.");
                return;
            }

            Console.WriteLine("Animals in the zoo:");
            foreach (var animal in _animals)
            {
                Console.WriteLine($"- {animal.Name}, Age: {animal.Age}");
            }
        }

        public void UpdateAnimal(string name, string newName, int newAge)
        {
            var animal = _animals.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (animal != null)
            {
                animal.Update(newName, newAge);
                Console.WriteLine($"Updated {name} to {newName}, Age: {newAge}.");
            }
            else
            {
                Console.WriteLine($"Animal with name {name} not found.");
            }
        }

        public void DeleteAnimal(string name)
        {
            var animal = _animals.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (animal != null)
            {
                _animals.Remove(animal);
                Console.WriteLine($"Deleted {animal.Name} from the zoo.");
            }
            else
            {
                Console.WriteLine($"Animal with name {name} not found.");
            }
        }
    }
}
