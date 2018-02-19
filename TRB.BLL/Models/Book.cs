using System;
using System.Data;

namespace TRB.BLL.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }

        public Book() { }

        public Book(DataRow dr)
        {
            BookId = Convert.ToInt32(dr["BookId"]);
            Name = Convert.ToString(dr["BookName"]);
            Author = Convert.ToString(dr["BookAuthor"]);
            Year = Convert.ToString(dr["BookYear"]);
            Description = Convert.ToString(dr["BookDescription"]);
        }
    }
}
