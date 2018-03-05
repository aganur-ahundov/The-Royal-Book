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
﻿using System.Collections.Generic;
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

		public static List<Category> GetTestCategories()
		{
			return new List<Category>()
			{
				new Category { CategoryName = "Программирование", CategoryImage = "/Content/img/Categories/program_lang-1.png" },
				new Category { CategoryName = "Алгоритмы", CategoryImage = "/Content/img/Categories/algorithms-9.png" },
				new Category { CategoryName = "Личностный рост", CategoryImage = "/Content/img/Categories/self_improving-1.png" },
				new Category { CategoryName = "Другое", CategoryImage = "/Content/img/Categories/others-2.png" }
			};
		}
	}
}
