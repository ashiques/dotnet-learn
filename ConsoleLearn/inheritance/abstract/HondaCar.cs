namespace inheritance
{
    class HondaCar : AbstractCar
    {
        public override void Honk()
        {
            System.Console.WriteLine("Hoink Hoink..");
        }
    }
}