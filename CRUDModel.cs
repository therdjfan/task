using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace MVCwithADO.Models
{
    public class CRUDModel
    {
        //get all records from db
        public DataTable GetAllProduct()
        {
            DataTable dt = new DataTable();
            string strConString = @"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;";
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from prod", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        //get product deatils by their id
        public DataTable GetProductByID(int intProductID)
        {
            DataTable dt = new DataTable();

            string strConString = @"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;";

            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from prod where ProductId=" + intProductID, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        //Upadte Table

        public int UpdateProduct( string strProductName, int intCategory, string strCategory)
        {
            string strConString = @"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;";

            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Update prod SET ProductName=@prodName, CategoryId=@catId , CategoryName=@catName where ProductId=@prodId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prodName", strProductName);
                cmd.Parameters.AddWithValue("@catId", intCategory);
                cmd.Parameters.AddWithValue("@catName", strCategory);
               

                return cmd.ExecuteNonQuery();
            }
        }

        //insert data into table
        public int InsertProduct(int intProduct, string strProductName, int intCategory, string strCategory)
        {
            string strConString = @"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;";

            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Insert into prod (ProductId,ProductName, CategoryId,CategoryName) values(@prodID, @prodName , @catID,@catName)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prodID", intProduct);
                cmd.Parameters.AddWithValue("@prodName", strProductName);
                cmd.Parameters.AddWithValue("@catID", intCategory);
                cmd.Parameters.AddWithValue("@catName", strCategory);
                return cmd.ExecuteNonQuery();
            }
        }


        //Delete table

        public int DeleteProduct(int intProductID)
        {
            string strConString = @"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;";

            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Delete from prod where ProductId=@prodid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prodid", intProductID);
                return cmd.ExecuteNonQuery();
            }
        }


    }
}