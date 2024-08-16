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
    public partial class dropdown : System.Web.UI.Page
    {
        string c = ConfigurationManager.ConnectionStrings["dd"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dd();
            }
        }
        public void dd()
        {
            SqlConnection con = new SqlConnection(c);
            con.Open();
            string q = "select id from aaa";
            SqlCommand com = new SqlCommand(q, con);
            SqlDataReader dr = com.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataTextField = "id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "select");
            con.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue != "0")
            {
                grid(DropDownList1.SelectedIndex);
            }
            //SqlConnection con = new SqlConnection(c);
            //con.Open();
            //SqlCommand com = new SqlCommand("select * from aaa where Date='" + DropDownList1.SelectedItem.Text+ "'",con);
            //SqlDataReader dr = com.ExecuteReader();
            //GridView2.DataSource = dr;
            //GridView2.DataBind();
            //con.Close();
           // grid();
        }

       
        public void grid(int id)
        {
            SqlConnection con = new SqlConnection(c);
            con.Open();
            id = Convert.ToInt32(Console.ReadLine());
            string q = "select * from aaa where id=@id";
            SqlCommand com = new SqlCommand(q, con);
            com.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = com.ExecuteReader();
            
            //SqlDataAdapter da = new SqlDataAdapter(q, con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            GridView2.DataSource = dr;
            GridView2.DataBind();
            con.Close();
            
        }
    }
}