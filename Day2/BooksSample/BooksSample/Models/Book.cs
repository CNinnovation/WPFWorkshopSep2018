using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class Book
    {
        public Book()
        {

        }
        public int BookdId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string[] Authors { get; set; }
        public override string ToString() => Title;
    }
}
