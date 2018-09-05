using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSample.Models
{
    public class Book
    {
        public Book()
        {


        }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
