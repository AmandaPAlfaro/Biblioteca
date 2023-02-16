namespace LibraryApp
{
    public class Book
    {
        public string Author { get; set;}
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Editorial { get; set; }
        
        public Book(string author, string title, int pages, string editorial)
        {
            this.Author = author;
            this.Title = title;
            this.Pages = pages;
            this.Editorial = editorial;
        }

    }
}
