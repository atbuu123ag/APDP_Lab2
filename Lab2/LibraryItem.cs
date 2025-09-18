using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string publicationDate { get; set; }
        public Boolean Available { get; set; }

        public abstract void CheckOut();
        public abstract void ReturnItem();

        public LibraryItem(string title, string author, string publicationDate)
        {
            Title = title;
            Author = author;
            publicationDate = publicationDate;
            Available = true;
        }
    }
}
