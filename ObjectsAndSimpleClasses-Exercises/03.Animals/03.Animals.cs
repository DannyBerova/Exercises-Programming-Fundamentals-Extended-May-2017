
namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
    
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dog> dogs = new Dictionary<string, Dog>();
            Dictionary<string, Cat> cats = new Dictionary<string, Cat>();
            Dictionary<string, Snake> snakes = new Dictionary<string, Snake>();

            string inputLine = Console.ReadLine();

            while (inputLine != "I'm your Huckleberry")
            {
                string[] tokens = inputLine.Split(' ');

                if (tokens.Length > 2)
                {
                    string type = tokens[0];
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int parameter = int.Parse(tokens[3]);

                    switch (type)
                    {
                        case "Dog":
                            Dog newDog = new Dog();
                            newDog.Name = name;
                            newDog.Age = age;
                            newDog.NumberOfLegs = parameter;

                            dogs.Add(newDog.Name, newDog);
                            break;
                        case "Cat":
                            Cat newCat = new Cat();
                            newCat.Name = name;
                            newCat.Age = age;
                            newCat.IntelligenceQuotient = parameter;

                            cats.Add(newCat.Name, newCat);
                            break;
                        case "Snake":
                            Snake newSnake = new Snake();
                            newSnake.Name = name;
                            newSnake.Age = age;
                            newSnake.CrueltyCoefficient = parameter;

                            snakes.Add(newSnake.Name, newSnake);
                            break;

                    }
                }
                else
                {
                    string animalName = tokens[1];

                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(animalName))
                    {
                        snakes[animalName].ProduceSound();
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine(
                    $"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine(
                    $"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine(
                    $"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
