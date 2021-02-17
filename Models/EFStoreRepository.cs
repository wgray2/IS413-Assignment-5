using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Assignment_5.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        //Use underscore for private variables
        private StoreDbContext _context;

        //Constructor
        public EFStoreRepository (StoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
