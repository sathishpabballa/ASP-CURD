using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ssssssv
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string c = ConfigurationManager.ConnectionStrings["sa"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(c);
            con.Open();
            int id = Convert.ToInt32(tb1.Text);
            int pno = Convert.ToInt32(tb6.Text);
            int age = Convert.ToInt32(tb5.Text);
            //string r;
            //if (RadioButton1.Checked == true)
            //{
            //     r = RadioButton1.Text;
            //}
            //else if(RadioButton2.Checked== true)
            //{
            //    r = RadioButton2.Text;
            //}
            string chb;

            chb = CheckBox1.Text;
            chb = CheckBox1.Text + "," + CheckBox2.Text;
            string ddl = DropDownList1.SelectedItem.Text;
            SqlCommand com = new SqlCommand("prc_rinsert", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", id);
            com.Parameters.AddWithValue("@Name", tb2.Text);
            com.Parameters.AddWithValue("@Password", tb3.Text);
            com.Parameters.AddWithValue("@ConfirmPassword", tb4.Text);
            com.Parameters.AddWithValue("@Age", age);
            com.Parameters.AddWithValue("@Gender", RadioButton1.Text);
            com.Parameters.AddWithValue("@Language", chb);
            com.Parameters.AddWithValue("@Phone", pno);
            com.Parameters.AddWithValue("@Email", tb7);

            com.Parameters.AddWithValue("@Address", ddl);
            com.Parameters.AddWithValue("@Photo", FileUpload1);
            com.ExecuteNonQuery();
            con.Close();











        
        }
    }
}