namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public string DisplayInfo()
        {
            return $"{Id}: {Title} by {Author} - {(IsAvailable ? "Available" : "Not Available")}";
        }
    }
}
