using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

using System.Net.NetworkInformation;

namespace ssssssv
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {



            try
            {

                Random obj = new Random();
                int a = obj.Next(1000, 9999);

                string s = a.ToString();
                Label1.Text = s;

            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
            finally
            {
                // Label1.Text = "hlo";
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string n = TextBox1.Text;
            Label2.Text = n;

        }
    }
}