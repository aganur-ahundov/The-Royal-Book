using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRB.BLL.Helpers;
using TRB.BLL.Models;

namespace TRB.BLL.Providers
{
    public static class BooksProvider
    {
        //public static List<Book> GetBooks()
        //{
        //    var result = new List<Book>();
        //    var dt = DBHelper.ExecuteScalar("Proc_Books_Select", CommandType.StoredProcedure);

        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        result.Add(dt.Rows.OfType<DataRow>().Select(row => new Book(row)));
        //        foreach (var item in dt.Rows)
        //        {
        //            new Book(item));
        //        }
        //    }
        //}
    }
}
