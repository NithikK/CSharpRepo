using Microsoft.AspNetCore.Mvc;
using MVCAuthor.Models;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace MVCAuthor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Editor()
        {
            return View();
        }
        public IActionResult Finder()
        {
            return View();
        }
        public IActionResult Deleter()
        {
            return View();
        }
        public IActionResult CreateAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SaveNewAuthor(Author pauthor)
        {
            String fName = @"C:\Users\nithik.k\source\Traning Phase\authors.csv";
            String strAuthor = $"{pauthor.AuthorID}, {pauthor.AuthorName}, {pauthor.TotalBooks}, {pauthor.Royalty}, {pauthor.DOB}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
            return View(pauthor);
        }
        public IActionResult ListAllAuthor()
        {
            String fName = @"C:\Users\nithik.k\source\Traning Phase\authors.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        public IActionResult FindAuthor(int authorID)
        {
            return View(Find(authorID));
        }
        private Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.TotalBooks = int.Parse(data[2]);
            author.Royalty = data[3];
            author.DOB = DateTime.Parse(data[4]);
            return author;
        }
        public IActionResult Edit(String eid)
        {
            List<Author> list = Find(int.Parse(eid));
            Author author = list[0];
            return View(author);
        }
        public IActionResult ModifyAuthor(Author pauthor)
        {
            String fName = @"C:\Users\nithik.k\source\Traning Phase\authors.csv";
            String strAuthor = $"{pauthor.AuthorID}, {pauthor.AuthorName}, {pauthor.TotalBooks}, {pauthor.Royalty}, {pauthor.DOB}";
            List<Author> list = new List<Author>();
            list = Find(pauthor.AuthorID);
            if (list.Count != 0)
            {
                int index = FindIndex(pauthor.AuthorID);
                DeleteLine(index);
            }
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);  
            }
            return View(pauthor);
        }
        public ActionResult Delete(String did)
        {
            
            List<Author> list = Find(int.Parse(did));
            Author author = list[0];
            int index = FindIndex(int.Parse(did));
            DeleteLine(index);
            return View(author);
        }
        public ActionResult Show(String sid)
        {

            List<Author> list = Find(int.Parse(sid));
            Author author = list[0];
            return View(author);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private List<Author> Find(int id) {
            String fName = @"C:\Users\nithik.k\source\Traning Phase\authors.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Author author = StringToAuthor(data, new Author());
                if (author.AuthorID == id)
                {
                    list.Add(author);
                }

                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new Author());
                    if (author.AuthorID == id)
                    {
                        list.Add(author);
                    }
                }
            }
            return list;
        }
        private int FindIndex(int id)
        {
            String fName = @"C:\Users\nithik.k\source\Traning Phase\authors.csv";
            List<Author> list = new List<Author>();
            int count = 0;
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Author author = StringToAuthor(data, new Author());
                bool flag = true;
                if (flag)
                    count++;
                if (author.AuthorID == id)
                {
                    list.Add(author);
                    flag = false;
                }

                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new Author());
                    if (flag)
                        count++;
                    if (author.AuthorID == id)
                    {
                        list.Add(author);
                        flag = false;
                    }
                }
            }
            return count;
        }
        private void DeleteLine(int index) {
            string filePath = @"C:\Users\nithik.k\source\Traning Phase\authors.csv";
            int line_Delete = index;
            string tempFilePath = @"C:\Users\nithik.k\source\Traning Phase\tempauthor.txt";
            using (StreamReader reader = new StreamReader(filePath))
            using (StreamWriter writer = new StreamWriter(tempFilePath))
            {
                int count = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (count != line_Delete)
                    {
                        writer.WriteLine(line);
                        count++;
                    }
                }
            }
            using (StreamReader reader = new StreamReader(tempFilePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                    
                }
            }

        }
    }
}