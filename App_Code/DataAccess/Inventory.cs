using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Nits.Model;
using Nits.Common;

/// <summary>
/// Summary description for Inventory
/// </summary>
namespace Nits.BLL
{
    public class Category
    {
        public string AddCategory(StockCategory Category)
        {
            try
            {
                SqlParameter[] var =
          {
                new SqlParameter("@CatName",Category.CatName),
                new SqlParameter("@UserName",Category.UserName),
            };
                int Count = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.Connect, CommandType.Text, "select count(CatId) from StockCategory where CatName=@CatName", var));
                if (Count == 0)
                {
                    int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "insert into StockCategory (CatName,UserName) values(@CatName,@UserName)", var);
                    if (returnValue > 0)
                    {
                        return "Successfully Added";
                    }
                    else
                    {
                        return "Something went wrong. Please try again later!";
                    }
                }
                else
                {
                    return "Category Name already Exist";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public DataSet getCategories()
        {
            DataSet ds=SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select * from StockCategory where IsDeleted=0");
            return ds;
        }
    }
}