namespace inheritance
{
    class Pig : IAnimalMotion, IAnimalSound
    {
        public void animalSound()
        {
            System.Console.WriteLine("Oink Oink!");
        }

        public void run()
        {
            System.Console.WriteLine("Pig is running..");
        }
    }
}