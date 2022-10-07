




class Book
{
   public string title;
   public string author;
   public string pages;
}

static void Main(string[] args)
{
    Book book1 = new Book();
    book1.title= "Harry Potter";
    book1.author = "JK Rowlings";
    book1.pages = 499;

    Console.WriteLine(book1.Title);
    Console.ReadLine();
    }


