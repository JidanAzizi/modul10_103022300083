namespace modul10_103022300083
{
    public class Movies
    {
        public string title { get; set; }
        public string director { get; set; }
        public List<string> Starts { get; set; }

        public string Description { get; set; }

        public Movies(string title, string director, List<string> starts, string description)
        {
            this.title = title;
            this.director = director;
            Starts = starts;
            Description = description;
        }
    }
}
