namespace LibraryA
{
    public class BookA
    {
        public String Title = String.Empty;
        public String Author = String.Empty;
        public String Genre = String.Empty;
        public DateTime DateOfPublished;
        public int BookPrice;
        public int TotalPages = 100;
        public void OpenBook()
        {
            Console.WriteLine("Book is Open");
        }
        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"Page No : {pageNo} Bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }
    }
}