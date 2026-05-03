using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore
{
    internal class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int NumberOfPages { get; set; }

        public DateTime YearOfPublish { get; set; }

        public string Status { get; set; }
    }
}
