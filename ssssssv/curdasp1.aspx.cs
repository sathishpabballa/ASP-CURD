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
    public partial class curdasp1 : System.Web.UI.Page
    {
        string s = ConfigurationManager.ConnectionStrings["cs"].ToString();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                dis();
        }
        public void dis()
        {
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("prc_sel",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            con.Open();
            string gen = "";
            if (RadioButton1.Checked == true)
                gen = RadioButton1.Text;
            else if (RadioButton2.Checked == true)
                gen = RadioButton2.Text;
            string hob = "";
            if (CheckBox1.Checked == true)
                hob = CheckBox1.Text;
            else if (CheckBox2.Checked == true)
                hob = CheckBox2.Text;
            int pno = Convert.ToInt32(TextBox3.Text);
            SqlCommand cd = new SqlCommand("prc_in", con);
            cd.CommandType = CommandType.StoredProcedure;
            cd.Parameters.AddWithValue("@Id",TextBox1.Text);
            cd.Parameters.AddWithValue("@Name", TextBox2.Text);
            cd.Parameters.AddWithValue("@Gender", gen);
            cd.Parameters.AddWithValue("@PhoneNo", pno);
            cd.Parameters.AddWithValue("@Email", TextBox4.Text);
            cd.Parameters.AddWithValue("@Hobbies", hob);
            cd.Parameters.AddWithValue("@City", TextBox5.Text);
            cd.Parameters.AddWithValue("@Address", TextBox6.Text);
            cd.ExecuteNonQuery();
            con.Close();
            dis();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Control c = row.FindControl("Label1");
            Label l1 = (Label)c;
            con.Open();
            SqlCommand cmd = new SqlCommand("prc_del",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id",l1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dis();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            dis();

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
            TextBox t4 = (TextBox)c;
            Control c4 = row.FindControl("TextBox5");
            TextBox t5 = (TextBox)c4;
            Control c5 = row.FindControl("TextBox6");
            TextBox t6 = (TextBox)c5;
            Control c6 = row.FindControl("TextBox7");
            TextBox t7 = (TextBox)c6;
            Control c7 = row.FindControl("TextBox8");
            TextBox t8 = (TextBox)c7;
            con.Open();
            SqlCommand cmd = new SqlCommand("prc_up",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", t1.Text);
            cmd.Parameters.AddWithValue("@Name",t2.Text);
            cmd.Parameters.AddWithValue("@Gender", t3.Text);
            cmd.Parameters.AddWithValue("@PhoneNo", t4.Text);
            cmd.Parameters.AddWithValue("@Email", t5.Text);
            cmd.Parameters.AddWithValue("@Hobbies", t6.Text);
            cmd.Parameters.AddWithValue("@City", t7.Text);
            cmd.Parameters.AddWithValue("@Address", t8.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            GridView1.EditIndex = -1;
            dis();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            dis();

        }
    }
}