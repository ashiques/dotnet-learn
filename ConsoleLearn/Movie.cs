namespace Sample
{
    class Movie
    {
        private string rating;
        private string director { get; set; }
        private string title { get; set; }
        public Movie(string aTitle, string aDirector, string aRating)
        {
            Rating = aRating;
            director = aDirector;
            title = aTitle;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "R" || value == "NR" || value == "PG-13")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}