using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;

namespace ssssssv
{
    public partial class Json_to_Gridview_Bind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                grid();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void grid()
        {
            string json = "Ranga";
            dynamic obj = JsonConvert.DeserializeObject(json);
            GridView1.DataSource = obj;
            GridView1.DataBind();
        }
    }
}