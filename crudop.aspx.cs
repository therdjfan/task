using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Task11
{
    public partial class crudop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Con.ConnectionString = "Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;";
            Con.Open();
           
            if (!IsPostBack)
            {
                loadrecord();
            }
        }

        protected void btnnsert_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;");
            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into prod values('" + proid.Text + "','" + proname.Text + "','" + catid.Text + "','" + catname.Text + "')", Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            loadrecord();
        }
        void loadrecord()
        {
            SqlCommand cmd = new SqlCommand("select * from prod", Con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;");
            Con.Open();
            SqlCommand cmd = new SqlCommand("update  prod set ProductName='" + proname.Text + "',CategoryId='" + catid.Text + "', CategoryName='" + catname.Text + "' where ProductId ='" + proid.Text + "'", Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            loadrecord();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;");
            Con.Open();
            SqlCommand cmd = new SqlCommand("delete prod  where ProductId='" + proid.Text + "'", Con);
            cmd.ExecuteNonQuery();

            Con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            loadrecord();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from prod where ProductId='" + proid.Text + "'", Con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Getdata_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source= DESKTOP-7EQALH8; Initial Catalog=bloodpro; Integrated Security=SSPI;");
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from prod where ProductId='" + proname.Text + "'", Con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {

                proname.Text = r.GetValue(1).ToString();
                catid.Text = r.GetValue(2).ToString();
                catname.Text = r.GetValue(3).ToString();


            }
        }
    }
}