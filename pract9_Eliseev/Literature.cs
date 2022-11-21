using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract9_Eliseev
{
    struct Literature
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }   

        public Literature(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }

    }

}
