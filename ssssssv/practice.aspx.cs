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
    public partial class practice : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(c);
            con.Open();
            SqlCommand cmd = new SqlCommand("p_1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);
            cmd.Parameters.AddWithValue("@email", TextBox3.Text);
            cmd.Parameters.AddWithValue("@phoneno", TextBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(c);
            con.Open();
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Control c1 = row.FindControl("TextBox1");
            TextBox t1 = (TextBox)c1;
            Control c2 = row.FindControl("TextBox2");
            TextBox t2 = (TextBox)c2;
            Control c3 = row.FindControl("TextBox3");
            TextBox t3 = (TextBox)c3;
            Control c4 = row.FindControl("TextBox4");
            TextBox t4 = (TextBox)c4;
            SqlCommand cmd = new SqlCommand("p_3", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", t1.Text);
            cmd.Parameters.AddWithValue("@password", t2.Text);
            cmd.Parameters.AddWithValue("@email", t3.Text);
            cmd.Parameters.AddWithValue("@phoneno", t4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            display();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            display();
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

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            display();
        }
    }
}