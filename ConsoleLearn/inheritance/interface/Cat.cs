namespace inheritance
{
    class Cat : IAnimalMotion, IAnimalSound
    {
        public void animalSound()
        {
            System.Console.WriteLine("Meow Meow!");
        }

        public void run()
        {
            System.Console.WriteLine("Cat is running..");
        }
    }
}