using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This lets us set up how many pages there will be by getting number of books and books per page
namespace IS413_Assignment_5.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
