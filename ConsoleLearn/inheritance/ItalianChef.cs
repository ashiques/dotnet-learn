namespace inheritance
{
    //inheritance in action
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            System.Console.WriteLine("Italian Chef makes Spagetti with meatball sauce");
        }

    }
}