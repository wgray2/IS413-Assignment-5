using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Assignment_5.Models
{
    //This is the class for books. It includes the information in the instructions
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        [Key]
        public string ISBN { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public float Price { get; set; }
        public int NumPages { get; set; }
    }
}
