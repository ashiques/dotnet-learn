

namespace inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            System.Console.WriteLine("Chef makes chicken");
        }
        public void MakeSalad()
        {
            System.Console.WriteLine("Chef makes salads");
        }

        public virtual void MakeSpecialDish()
        {
            System.Console.WriteLine("chef makes bbq ribs");
        }
    }
}