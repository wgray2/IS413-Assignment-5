using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Assignment_5.Models
{
    public interface IStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
