using LibraryA;

BookA book = new BookA();
book.Title = "to kill a mocking bird";
book.Author = "harper Lee";
book.Genre = "Social";
book.BookPrice = 100;
book.DateOfPublished = DateTime.Now;
book.BookmarkPage(125);
Console.WriteLine(book.GetCurrentPage);
Calculator calculator = new Calculator();
int addResult = calculator.Add(100, 50);
Console.WriteLine(addResult);
int multiplyResult = calculator.Multiply(100, 50);
Console.WriteLine(multiplyResult);
