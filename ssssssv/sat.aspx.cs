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
    public partial class sat : System.Web.UI.Page
    {
        string s = ConfigurationManager.ConnectionStrings["cs"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack!=true)
            {
                display();
            }
        }
        public void display()
        {
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("pec_select",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();

        }
        public void clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("prc_add22",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId",TextBox1.Text);
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
            cmd.Parameters.AddWithValue("City",TextBox3.Text);
            cmd.Parameters.AddWithValue("@Address",TextBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
            clear();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Control c = row.FindControl("Label1");
            Label l1 = (Label)c;
            con.Open();
            SqlCommand cmd = new SqlCommand("prc_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", l1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
            clear();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            display();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            display();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Control c = row.FindControl("TextBox1");
            TextBox t1 = (TextBox)c;
            Control c1 = row.FindControl("TextBox2");
            TextBox t2 = (TextBox)c1;
            Control c2 = row.FindControl("TextBox3");
            TextBox t3 = (TextBox)c2;
            Control c3 = row.FindControl("TextBox4");
            TextBox t4 = (TextBox)c3;
            con.Open();
            SqlCommand cmd = new SqlCommand("prc_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", t1.Text);
            cmd.Parameters.AddWithValue("@Name",t2.Text);
            cmd.Parameters.AddWithValue("@City", t3.Text);
            cmd.Parameters.AddWithValue("@Address", t4.Text);
            cmd.ExecuteNonQuery();
           
            con.Close();
            GridView1.EditIndex = -1;
            display();
            clear();
        }
    }
}