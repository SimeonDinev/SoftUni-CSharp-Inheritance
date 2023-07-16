using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string type = Console.ReadLine();
                string[] animalInfo = Console.ReadLine().Split();

                if (type == "Beast!")
                {
                    break;
                }
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];



                if (age < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (type == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine($"{dog.Name} {dog.Age} {dog.Gender}");
                    dog.ProduceSound();
                }
                else if (type == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine($"{frog.Name} {frog.Age} {frog.Gender}");
                    frog.ProduceSound();
                }
                else if (type == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    Console.WriteLine($"{cat.Name} {cat.Age} {cat.Gender}");
                    cat.ProduceSound();
                }
                else if (type == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    Console.WriteLine($"{kitten.Name} {kitten.Age}");
                    kitten.ProduceSound();
                }
                else if (type == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    Console.WriteLine($"{tomcat.Name} {tomcat.Age}");
                    tomcat.ProduceSound();
                }
            }
        }
    }
}

