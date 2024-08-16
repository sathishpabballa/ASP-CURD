using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ssssssv
{
    public partial class Grid : System.Web.UI.Page
    {
        string c = ConfigurationManager.ConnectionStrings["cs"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                display();

        }
        public void display()
        {
            SqlConnection con = new SqlConnection(c);
            con.Open();
            SqlCommand cmd = new SqlCommand("p_2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection(c);
            con.Open();
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Control c1 = row.FindControl("Label1");
            Label l1 = (Label)c1;
            SqlCommand cmd = new SqlCommand("p_4", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", l1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }
    }
}