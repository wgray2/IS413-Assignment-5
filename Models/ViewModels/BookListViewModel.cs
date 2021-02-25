using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Gets paging info and lists out books for page
namespace IS413_Assignment_5.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
