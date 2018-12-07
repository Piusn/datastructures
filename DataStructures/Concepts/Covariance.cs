using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Concepts
{
    public class Animal
    {
        public void Eat() => Console.WriteLine("Animal is eating");
    }

    public class Bird : Animal
    {
        public void Fly() => Console.WriteLine("The bird is flying");
    }

    delegate Animal ReturnAnimalDelegate();
    delegate Bird ReturnBirdDelegate();

    delegate void TakeAnimalDelegate(Animal a);
    delegate void TakeBirdDelegate(Bird b);

    //Covariance - Preserves assignment compatibility
    //Contravariance - reverses assignment

    //Delegate are covariant
    //Parameters are contravariant while return type is covariant

    public class Covariance
    {
        public static Bird GetBird() => new Bird();
        public static Animal GetAnimal() => new Animal();

        public void Eat(Animal animal) => animal.Eat();
        public void Fly(Bird bird) => bird.Fly();

        public List<Bird> Take(List<Bird> bird) {
            return bird;

        }
        public void Run()
        {
            //This is covariant. The delegate can take any method that return an animal or its 
            //derived classes

            ReturnAnimalDelegate animal = GetBird; // Allowed

            // ReturnBirdDelegate bird = GetAnimal;  Not allowed
            TakeBirdDelegate takeBird = Fly;
            TakeBirdDelegate takeBird2 = Eat;
            Take(new List<Bird>());

            takeBird2(new Bird());

            //TakeAnimalDelegate takeAnimal = Fly;
        }
    }
}
