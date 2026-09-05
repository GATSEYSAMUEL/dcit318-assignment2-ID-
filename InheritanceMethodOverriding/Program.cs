public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}



public class Program
{
    public static void Main ()
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();


        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();        
    }
}
