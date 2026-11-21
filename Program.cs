namespace Assignment2
{
    using System.Drawing;
    using System.Runtime.Intrinsics.X86;
    using System.Text;
    using System.Xml.Linq;
    using static System.Runtime.InteropServices.JavaScript.JSType;



    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(upperTitle);
            Console.WriteLine(title);





            #endregion
            #region Q2


            string s1 = "clean code";
            string s2 = "clean code";
            Console.WriteLine(ReferenceEquals(s1, s2));




            #endregion
            #region Q3



            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Book List");
            sb1.Append(" - Updated");
            Console.WriteLine(sb1);
            #endregion


            #region Q4


            sb1.Replace("Book List", "Library");
            Console.WriteLine(sb1);



            #endregion
            #region Q5


            string Title = "clean code";
            int pages = 464;

            Console.WriteLine("Book : " + Title + "   Pages : " + pages);




            #endregion
            #region Q6


            Console.WriteLine($"Book : {Title}" + $"   Pages : {pages}");

            #endregion
            #region Q7


            Console.WriteLine(string.Format("Book : {0}   Pages : {1}", Title, pages));

            #endregion
            #region Q8

            pages = 464;
            if (pages > 300)
                Console.WriteLine("Long Book");
            else
                Console.WriteLine("Short Book");

            #endregion
            #region Q9


            pages = 455;
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
                Console.WriteLine("You can borrow this book");


            #endregion
            #region Q10


            string ttitle = "Refactoring";

            switch (ttitle)
            {
                case "Clean code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;



            }

            #endregion
            #region Q11


            string sizelabel = pages > 300 ? "Long book" : "Short Book";


            #endregion
            #region Q12

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {

                Console.WriteLine((i + 1) + "-" + books[i]);

            }
            #endregion
            #region Q13

            int j = 0;
            while (j < books.Length)
            {

                Console.WriteLine((j + 1) + "-" + books[j]);
                j++;
            }


            #endregion
            #region Q14
            int x = 0;

            do
            {
                Console.WriteLine("Checking book...");
                x++;
            } while (x < 3);


            #endregion
            #region Q15  
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            #endregion
            #region Q16   
            for (int i = 0; i < books.Length; i++)
            {

                if (books[i] == "Refactoring")
                    break;

                Console.WriteLine((i + 1) + "-" + books[i]);
            }



            #endregion
            #region Q17 
            for (int i = 0; i < books.Length; i++)
            {

                if (books[i] == "The Pragmatic Programmer")
                    continue;

                Console.WriteLine((i + 1) + "-" + books[i]);
            }
            #endregion
            #region Q18 

            static void PrintFirstBook(string[] array)
            {
                if (array.Length == 0)
                {
                    return;
                }


                Console.WriteLine(array[0]);
            }


            PrintFirstBook(books);





            #endregion
        }
    }
}