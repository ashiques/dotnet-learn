namespace inheritance
{
    abstract class AbstractCar
    {
        public abstract void Honk();
        public void move()
        {
            System.Console.WriteLine("Car is moving");
        }
    }
}