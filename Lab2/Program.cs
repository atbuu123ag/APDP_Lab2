using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LibraryItem book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "1925", "Fiction"); 
            //LibraryItem dvd1 = new DVD("Inception", "Christopher Nolan", "2010", 148);
            //book1.CheckOut();
            //Console.WriteLine("The "+ book1.Title + " status: " +book1.Available);
            //dvd1.CheckOut();
            //Console.WriteLine("The " + dvd1.Title + " status: " + dvd1.Available);

            //Console.WriteLine("---------------------------------");
            //System.Threading.Thread.Sleep(3000); 
            //book1.ReturnItem();
            //Console.WriteLine("The " + book1.Title + " status: " + book1.Available);
            //dvd1.ReturnItem();
            //Console.WriteLine("The " + dvd1.Title + " status: " + dvd1.Available);

           LibraryCatalog catalog = new LibraryCatalog();
            catalog.AddItem(new Book("The Great Gatsby", "F. Scott Fitzgerald", "1925", "Fiction"));    
            catalog.AddItem(new DVD("Inception", "Christopher Nolan", "2010", 148));
            catalog.AddItem(new Book("To Kill a Mockingbird", "Harper Lee", "1960", "Fiction"));
            catalog.ListItems();
            Console.WriteLine("---------------------------------");
            catalog.FindItem("Great");
            Console.WriteLine("---------------------------------");
            catalog.CheckOutItem("The Great Gatsby");
            Console.WriteLine("---------------------------------");
            catalog.ListItems();
            Console.WriteLine("---------------------------------");
            catalog.ReturnItem("The Great Gatsby");

        }
    }
}
