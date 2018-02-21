using System.Collections.Generic;
using System.Data;
using TRB.BLL.Helpers;
using TRB.BLL.Models;

namespace TRB.BLL.Providers
{
    public static class CategoriesProvider
    {
        public static List<Category> GetCategories()
        {
            var result = new List<Category>();
            var dt = DBHelper.ExecuteScalar("Proc_Category_Select", CommandType.StoredProcedure);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    result.Add(new Category(row));
                }
            }

            return result;
        }
    }
}
