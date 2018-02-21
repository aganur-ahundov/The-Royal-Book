using System;
using System.Data;

namespace TRB.BLL.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }

        public Category() { }

        public Category(DataRow dr)
        {
            CategoryId = Convert.ToInt32(dr["CategoryId"]);
            CategoryName = Convert.ToString(dr["CategoryName"]);
            CategoryImage = Convert.ToString(dr["CategoryImage"]);
        }
    }
}
