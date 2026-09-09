using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5route
{
    internal class book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string title;
        public Genre genre { set; get; }
    }
    
       
}
