namespace Sample
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public int pages { get; set; }

        public Book(string title, string author, int pages)
        {
            this.author = author;
            this.pages = pages;
            this.title = title;
        }
        public Book()
        {

        }
    }
}

record Hero
{

}