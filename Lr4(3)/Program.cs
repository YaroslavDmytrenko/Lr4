namespace Third
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(2, "Kitty");
            Dog dog = new Dog(5, "Barbos");
            Deb<Pet> pet = new Deb<Pet>();
            pet.DebugResult(cat);
            pet.DebugResult(dog);
        }

    }
}